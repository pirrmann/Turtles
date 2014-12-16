module Window

open Runner

open System.Drawing
open System.Windows.Forms

let WIDTH = 800
let HEIGHT = 600

open Turtles

type State = {
    X: float
    Y: float
    Angle: float
    PenDown: bool
    Color: Color } with
    static member Default = { X = 0.; Y = 0.; Angle = 90.; PenDown = true; Color = RED }

let toSystemColor = function
    | RED -> System.Drawing.Color.Red
    | GREEN -> System.Drawing.Color.Green
    | BLUE -> System.Drawing.Color.Blue

type private Canvas() =
    inherit Control()
    do
        base.SetStyle(ControlStyles.UserPaint, true)
        base.SetStyle(ControlStyles.AllPaintingInWmPaint, true)
        base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true)

type Host() as this =
    inherit Form()
    let state = ref State.Default
    let canvas = new Canvas()

    let drawingBitmap = new Bitmap(WIDTH, HEIGHT)
    let mutable readyBitmap:Bitmap = new Bitmap(WIDTH, HEIGHT)

    let resetDrawing () =
        use gDraw = Graphics.FromImage(drawingBitmap)
        gDraw.Clear(Color.White)

    let repaint (o:obj) (e:PaintEventArgs) =
        let graphics = e.Graphics
        graphics.Clear(Color.White)
        graphics.TranslateTransform(single canvas.Size.Width/2.f, single canvas.Size.Height/2.f)
        graphics.ScaleTransform(single 1, single -1)

        let drawingArea = new Rectangle(-WIDTH/2, -HEIGHT/2, WIDTH, HEIGHT)
        graphics.DrawImage(readyBitmap, -WIDTH/2, -HEIGHT/2)
        graphics.DrawRectangle(Pens.Black, drawingArea)
        graphics.Clip <- new Region(drawingArea)

        graphics.TranslateTransform(single (!state).X, single (!state).Y)
        graphics.RotateTransform(single((!state).Angle))
        graphics.DrawImage(Image.FromFile("resources/turtle.png"), -18, -24, 48, 48)

    do
        this.Text <- "Turtle test"
        this.Width <- 640 + base.Width - base.ClientSize.Width
        this.Height <- 480 + base.Height - base.ClientSize.Height

        canvas.Top <- 0
        canvas.Left <- 0
        canvas.BackColor <- Color.White
        canvas.Dock <- DockStyle.Fill
        this.Controls.Add(canvas)

        canvas.Paint.AddHandler(new PaintEventHandler(repaint))
        this.Resize.Add(fun _ -> canvas.Invalidate())

        resetDrawing()

    let invalidate() =
        readyBitmap <- drawingBitmap.Clone() :?> Bitmap
        this.Invoke(new System.Action(canvas.Invalidate)) |> ignore

    member this.Handler(command) =
        match command with
        | UnitCommand.Reset ->
            resetDrawing ()
            state := State.Default
            invalidate()
        | UnitCommand.DoAction action ->
            use gDraw = Graphics.FromImage(drawingBitmap)
            gDraw.SmoothingMode <- System.Drawing.Drawing2D.SmoothingMode.None
            gDraw.TranslateTransform(single WIDTH / 2.f, single HEIGHT / 2.f)
            match action with
            | Walk (n, distanceUnit) ->
                let dots = distanceUnit.ToDots(n)
                //for _ in 1 .. dots do
                let x' = (!state).X + dots * cos ((!state).Angle * System.Math.PI / 180.)
                let y' = (!state).Y + dots * sin ((!state).Angle * System.Math.PI / 180.)
                if (!state).PenDown then
                    let color = (!state).Color |> toSystemColor
                    use pen = new Pen(color)
                    gDraw.DrawLine(pen, single (!state).X, single (!state).Y, single x', single y')
                state := {!state with X = x'; Y = y'}
                invalidate()
            | Turn (n, GRADATIONS, direction) ->
                for _ in 1..n do
                    let multiplier = match direction with | LEFT -> 1.0 | RIGHT -> -1.0
                    let angle' = (!state).Angle + multiplier * 15.0
                    state := {!state with Angle = angle'}
                invalidate()
            | LiftPenUp -> state := { !state with PenDown = false }
            | PutPenDown -> state := { !state with PenDown = true }
            | PickColor color -> state := { !state with Color = color }

open System.Threading
open System.Threading.Tasks

let Create () : UnitCommandHandler =
    let started = new TaskCompletionSource<Host>()
    let thread = new Thread(fun () ->
        let host = new Host()
        Application.Idle.Add(fun _ ->
            if not started.Task.IsCompleted
            then started.TrySetResult host |> ignore)
        Application.Run(host))

    thread.SetApartmentState(ApartmentState.STA)
    thread.Start()

    async {
        let! host = Async.AwaitTask started.Task
        let handler = host.Handler
        do UnitCommand.Reset |> handler
        return handler
    } |> Async.RunSynchronously

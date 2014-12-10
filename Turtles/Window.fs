module Window

open System.Drawing
open System.Windows.Forms

let WIDTH = 800
let HEIGHT = 600

open Turtles

type Command =
    | Reset
    | DoActions of Turtle

type Host = {
    Form:Form;
    Handler:Command->unit }

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

type Canvas() =
    inherit Control()
    do
        base.SetStyle(ControlStyles.UserPaint, true)
        base.SetStyle(ControlStyles.AllPaintingInWmPaint, true)
        base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true)

let Create () =
    let form = new Form()
    form.Text <- "Turtle test"
    form.Width <- 640 + form.Width - form.ClientSize.Width
    form.Height <- 480 + form.Height - form.ClientSize.Height

    let canvas = new Canvas()
    canvas.Top <- 0
    canvas.Left <- 0
    canvas.BackColor <- Color.White
    canvas.Dock <- DockStyle.Fill

    form.Controls.Add(canvas)

    let state = ref State.Default

    let drawing = new Bitmap(WIDTH, HEIGHT)
    let resetDrawing () =
        use gDraw = Graphics.FromImage(drawing)
        gDraw.Clear(Color.White)
    resetDrawing()

    let repaint (o:obj) (e:PaintEventArgs) =
        let graphics = e.Graphics
        graphics.Clear(Color.White)
        graphics.TranslateTransform(single canvas.Size.Width/2.f, single canvas.Size.Height/2.f)
        graphics.ScaleTransform(single 1, single -1)

        let drawingArea = new Rectangle(-WIDTH/2, -HEIGHT/2, WIDTH, HEIGHT)
        graphics.DrawImage(drawing, -WIDTH/2, -HEIGHT/2)
        graphics.DrawRectangle(Pens.Black, drawingArea)
        graphics.Clip <- new Region(drawingArea)

        graphics.TranslateTransform(single (!state).X, single (!state).Y)
        graphics.RotateTransform(single((!state).Angle))
        graphics.DrawImage(Image.FromFile("resources/turtle.png"), -18, -24, 48, 48)

    canvas.Paint.AddHandler(new PaintEventHandler(repaint))
    form.Resize.Add(fun _ -> canvas.Invalidate())

    let invalidate() =
        form.Invoke(new System.Action(canvas.Invalidate)) |> ignore
        Async.RunSynchronously (Async.Sleep 20)

    let handler command =
        match command with
        | Reset ->
            resetDrawing ()
            state := State.Default
            invalidate()
        | DoActions actions ->
            use gDraw = Graphics.FromImage(drawing)
            gDraw.SmoothingMode <- System.Drawing.Drawing2D.SmoothingMode.None
            gDraw.TranslateTransform(single WIDTH / 2.f, single HEIGHT / 2.f)
            for action in actions do
                match action with
                | Walk (n, STEPS) ->
                    for _ in 1..n do
                        let x' = (!state).X + 5. * cos ((!state).Angle * System.Math.PI / 180.)
                        let y' = (!state).Y + 5. * sin ((!state).Angle * System.Math.PI / 180.)
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

    { Form = form; Handler = handler }
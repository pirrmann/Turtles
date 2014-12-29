module Window

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
    | BLUE -> System.Drawing.Color.RoyalBlue
    | YELLOW -> System.Drawing.Color.Yellow
    | PINK -> System.Drawing.Color.DeepPink
    | ORANGE -> System.Drawing.Color.DarkOrange
    | PURPLE -> System.Drawing.Color.Purple

type private Canvas() =
    inherit Control()
    do
        base.SetStyle(ControlStyles.UserPaint, true)
        base.SetStyle(ControlStyles.AllPaintingInWmPaint, true)
        base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true)

[<RequireQualifiedAccess>]
type private InternalCommand =
    | Close
    | Reset
    | QueueAction of Avatar * Action
    | DoActions

[<RequireQualifiedAccess>]
type private WindowCommand =
    | Close
    | Reset
    | DoActions of (Avatar * Action) list

type Host() as this =
    inherit Form()
    let states = ref Map.empty<Avatar, State>
    let canvas = new Canvas()

    let drawingBitmap = new Bitmap(WIDTH, HEIGHT)
    let mutable readyBitmap:Bitmap = new Bitmap(WIDTH, HEIGHT)

    let resetDrawing () =
        use gDraw = Graphics.FromImage(drawingBitmap)
        gDraw.Clear(Color.White)

    let drawSprite =
        let sprite = Image.FromFile("resources/turtle.png")
        fun (Avatar(name, color)) (g:Graphics) ->
            g.DrawImage(sprite, -18, -24, 48, 48)
            match color with
            | Some color ->
                g.ScaleTransform(single 1, single -1)
                let systemColor = color |> toSystemColor
                use pen = new Pen(systemColor, 3.f)
                g.DrawLine(pen, 24, -2, 24, 4)
                if name.Length > 0 then
                    use font = new Font(FontFamily.GenericMonospace, 24.f, FontStyle.Bold, GraphicsUnit.Pixel)
                    use brush = new SolidBrush(systemColor)
                    let initial = name.Substring(0, 1).ToUpper() 
                    g.DrawString(initial, font, brush, -8.f, -12.f)
                g.ScaleTransform(single 1, single -1)
    
            | None -> ()

    let closing = ref false

    let onClosing (o:obj) (e:FormClosingEventArgs) =
        if not (!closing) then
            e.Cancel <- true
            this.Handler.Post Close

    let repaint (o:obj) (e:PaintEventArgs) =
        let graphics = e.Graphics
        graphics.Clear(Color.White)
        graphics.TranslateTransform(single canvas.Size.Width/2.f, single canvas.Size.Height/2.f)
        graphics.ScaleTransform(single 1, single -1)

        let drawingArea = new Rectangle(-WIDTH/2, -HEIGHT/2, WIDTH, HEIGHT)
        graphics.DrawImage(readyBitmap, -WIDTH/2, -HEIGHT/2)
        graphics.DrawRectangle(Pens.Black, drawingArea)
        graphics.Clip <- new Region(drawingArea)

        let baseTransform = graphics.Transform
        for avatar, state in !states |> Map.toSeq do
            graphics.Transform <- baseTransform
            graphics.TranslateTransform(single state.X, single state.Y)
            graphics.RotateTransform(single(state.Angle))
            drawSprite avatar graphics
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
        this.FormClosing.AddHandler(new FormClosingEventHandler(onClosing))
        this.Resize.Add(fun _ -> canvas.Invalidate())

        resetDrawing()

    let invalidate() =
        readyBitmap <- drawingBitmap.Clone() :?> Bitmap
        this.Invoke(new System.Action(canvas.Invalidate)) |> ignore

    let handler command =
        match command with
        | WindowCommand.Close ->
            closing := true
            this.Invoke(new System.Action(this.Close)) |> ignore
        | WindowCommand.Reset ->
            resetDrawing ()
            states := Map.empty<Avatar, State>
            invalidate()
        | WindowCommand.DoActions(actions) ->
            let mustInvalidate = ref false
            use gDraw = Graphics.FromImage(drawingBitmap)
            gDraw.SmoothingMode <- System.Drawing.Drawing2D.SmoothingMode.None
            gDraw.TranslateTransform(single WIDTH / 2.f, single HEIGHT / 2.f)
            for (avatar, action) in actions do
                let state = defaultArg ((!states).TryFind avatar) (State.Default)
                match action with
                | Walk (n, distanceUnit) ->
                    let dots = distanceUnit.ToDots(n)
                    let x' = state.X + float dots * cos (state.Angle * System.Math.PI / 180.)
                    let y' = state.Y + float dots * sin (state.Angle * System.Math.PI / 180.)
                    if state.PenDown then
                        let color = state.Color |> toSystemColor
                        use pen = new Pen(color)
                        gDraw.DrawLine(pen, single state.X, single state.Y, single x', single y')
                    states := (!states).Add(avatar, {state with X = x'; Y = y'})
                    mustInvalidate := true
                | Turn (n, GRADATIONS, direction) ->
                    let multiplier = match direction with | LEFT -> 1.0 | RIGHT -> -1.0
                    let angle' = state.Angle + float n * multiplier * 15.0
                    states := (!states).Add(avatar, {state with Angle = angle'})
                    mustInvalidate := true
                | LiftPenUp -> states := (!states).Add(avatar, { state with PenDown = false })
                | PutPenDown -> states := (!states).Add(avatar, { state with PenDown = true })
                | PickColor color -> states := (!states).Add(avatar, { state with Color = color })
            if (!mustInvalidate) then invalidate()

    let internalBox =
        let queuedActions = ref List.empty<Avatar * Action>
        MailboxProcessor.Start(fun inbox -> 
            let rec loop () = async { 
                let! msg = inbox.Receive()
                match msg with
                | InternalCommand.Close ->
                    WindowCommand.Close |> handler
                    return ()
                | InternalCommand.Reset ->
                    WindowCommand.Reset |> handler
                    return! loop()  
                | InternalCommand.QueueAction(avatar, action) ->
                    queuedActions := (avatar, action) :: (!queuedActions)
                    return! loop()
                | InternalCommand.DoActions ->
                    (!queuedActions)
                        |> List.rev
                        |> WindowCommand.DoActions
                        |> handler
                    queuedActions := List.empty
                    async {
                        do! Async.Sleep 20
                        inbox.Post InternalCommand.DoActions
                    } |> Async.Start
                    return! loop() }                   
            loop())

    let mailbox =
        internalBox.Post InternalCommand.DoActions
        MailboxProcessor.Start(fun inbox -> 
            let rec loop () = async { 
                let! msg = inbox.Receive()
                match msg with
                | Close ->
                    internalBox.Post InternalCommand.Close
                    return ()
                | Reset ->
                    internalBox.Post InternalCommand.Reset
                    return! loop()                 
                | DoAction(avatar, action) ->
                    internalBox.Post (InternalCommand.QueueAction(avatar, action))
                    return! loop() }                   
            loop())

    member this.Handler with get(): MailboxProcessor<Command> = mailbox

open System.Threading
open System.Threading.Tasks

let Create () : MailboxProcessor<Command> =
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
        do handler.Post Reset
        return handler
    } |> Async.RunSynchronously

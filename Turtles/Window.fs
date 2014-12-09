module Window

open System.Drawing
open System.Windows.Forms

open Turtles

type Command =
    | Reset
    | DoActions of Turtle

type Host = {
    Form:Form;
    Handler:Command->unit }

let wait() = 
    let WAIT_TIME = 20
    Async.Sleep WAIT_TIME
    |> Async.RunSynchronously

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

let Create () =
    let form = new Form()
    form.Text <- "Turtle test"
    form.Width <- 640 + form.Width - form.ClientSize.Width
    form.Height <- 480 + form.Height - form.ClientSize.Height

    let canvas = new PictureBox()
    canvas.Top <- 0
    canvas.Left <- 0
    canvas.Size <- form.ClientSize

    form.Controls.Add(canvas)

    let graphics = canvas.CreateGraphics()

    let state = ref State.Default

    let drawing = new Bitmap(640, 480, graphics)
    let resetDrawing () =
        use gDraw = Graphics.FromImage(drawing)
        gDraw.Clear(Color.White)
    resetDrawing()

    let repaint() =
        use final = new Bitmap(640, 480, graphics)
        use gFinal = Graphics.FromImage(final)
        gFinal.TranslateTransform(single 320, single 240)
        gFinal.ScaleTransform(single 1, single -1)
        gFinal.DrawImage(drawing, -320, -240)
        gFinal.TranslateTransform(single (!state).X, single (!state).Y)
        gFinal.RotateTransform(single((!state).Angle))
        gFinal.DrawImage(Image.FromFile("resources/turtle.png"), -18, -24, 48, 48)
        graphics.DrawImage(final, 0, 0)
        wait()

    let handler command =
        match command with
        | Reset ->
            resetDrawing ()
            state := State.Default
            repaint()
        | DoActions actions ->
            use gDraw = Graphics.FromImage(drawing)
            gDraw.SmoothingMode <- System.Drawing.Drawing2D.SmoothingMode.None
            gDraw.TranslateTransform(single 320, single 240)
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
                        repaint()
                | Turn (n, GRADATIONS, direction) ->
                    for _ in 1..n do
                        let multiplier = match direction with | LEFT -> 1.0 | RIGHT -> -1.0
                        let angle' = (!state).Angle + multiplier * 15.0
                        state := {!state with Angle = angle'}
                    repaint()
                | LiftPenUp -> state := { !state with PenDown = false }
                | PutPenDown -> state := { !state with PenDown = true }
                | PickColor color -> state := { !state with Color = color }

    { Form = form; Handler = handler }
open System
open System.Drawing
open System.Windows.Forms

open Turtles
open Turtles.DSL.English

[<EntryPoint>]
[<STAThread>]
let main argv = 
    let handler = Window.Create() |> Runner.Create

    let writer = turtle {
        LIFT THE PEN UP
        WALK 4 STEPS
        TURN 3 GRADATIONS TO THE LEFT
        WALK 5 STEPS
        TURN 3 GRADATIONS TO THE LEFT
        WALK 12 STEPS
        TURN 6 GRADATIONS TO THE RIGHT
        PUT THE PEN DOWN
        WRITE "MR T. SAYS:\nHELLO WORLD!\n\n"
    }

    writer |> Runner.DoActions |> handler

    0 // return an integer exit code
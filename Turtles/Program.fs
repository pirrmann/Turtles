open System
open System.Drawing
open System.Windows.Forms

open Turtles
open Turtles.DSL.English

[<EntryPoint>]
[<STAThread>]
let main argv = 
    let host = Window.Create()

    let writer = turtle {
        PUT THE PEN DOWN
        WRITE "MR T. SAYS:\nHELLO WORLD!\n\n"
    }

    let basePosition = turtle {
        LIFT THE PEN UP
        WALK 4 STEPS
        TURN 3 GRADATIONS TO THE LEFT
        WALK 5 STEPS
        TURN 3 GRADATIONS TO THE LEFT
        WALK 12 STEPS
        TURN 6 GRADATIONS TO THE RIGHT
    }

    let positionTop = turtle {
        LIFT THE PEN UP
        WALK 30 STEPS
        DO AS basePosition
    }

    let positionBottom = turtle {
        LIFT THE PEN UP
        TURN 12 GRADATIONS TO THE LEFT
        WALK 30 STEPS
        TURN 12 GRADATIONS TO THE LEFT
        DO AS basePosition
    }

    let positionLeft = turtle {
        LIFT THE PEN UP
        TURN 6 GRADATIONS TO THE LEFT
        WALK 50 STEPS
        DO AS basePosition
    }

    let positionRight = turtle {
        LIFT THE PEN UP
        TURN 6 GRADATIONS TO THE RIGHT
        WALK 50 STEPS
        DO AS basePosition
    }

    let center = Avatar.Create("_", host)
    let top = Avatar.Create("leonardo", host, color = BLUE)
    let bottom = Avatar.Create("raphael", host, color = RED)
    let left = Avatar.Create("michelangelo", host, color = ORANGE)
    let right = Avatar.Create("donatello", host, color = PURPLE)

    async {
        do center.Post(basePosition)
        do! Async.Sleep 1000
        do top.Post(positionTop)
        do bottom.Post(positionBottom)
        do left.Post(positionLeft)
        do right.Post(positionRight)

        do! Async.Sleep 3000
        do center.Post(writer)
        do top.Post(writer)
        do bottom.Post(writer)
        do left.Post(writer)
        do right.Post(writer)
    } |> Async.RunSynchronously

    0 // return an integer exit code
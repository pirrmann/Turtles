namespace Turtles.DSL

open Turtles

module internal Core =
    let STEP = STEPS
    let DOT = DOTS
    let GRADATION = GRADATIONS

    type AS_word = AS
    type TO_word = TO
    type THE_word = THE
    type PEN_word = PEN
    type UP_word = UP
    type DOWN_word = DOWN
    type TIMES_word = TIMES
    type WHAT_word = WHAT
    type DOES_word = DOES

    type CoreBuilder() =
        member x.Yield(()) = Seq.empty
        [<CustomOperation("WALK", MaintainsVariableSpace = true)>]
        member x.Walk(source:Turtle, nb, unit:Distance_Unit) =
            Seq.append source [Walk(nb, unit)]
        [<CustomOperation("TURN", MaintainsVariableSpace = true)>]
        member x.Turn(source:Turtle, nb, unit:Rotation_Unit, to_word:TO_word, the_word:THE_word, direction:Rotation_Direction) =
            Seq.append source [Turn(nb, unit, direction)]
        [<CustomOperation("LIFT", MaintainsVariableSpace = true)>]
        member x.LiftPenUp(source:Turtle, the_word:THE_word, pen_word:PEN_word, up_word:UP_word) =
            Seq.append source [LiftPenUp]
        [<CustomOperation("PUT", MaintainsVariableSpace = true)>]
        member x.PutPenDown(source:Turtle, the_word:THE_word, pen_word:PEN_word, down_word:DOWN_word) =
            Seq.append source [PutPenDown]
        [<CustomOperation("PICK", MaintainsVariableSpace = true)>]
        member x.PickColor(source:Turtle, the_word:THE_word, color:Color, pen_word:PEN_word) =
            Seq.append source [PickColor color]
        [<CustomOperation("DO", MaintainsVariableSpace = true)>]
        member x.Do(source:Turtle, as_word:AS_word, turtle:Turtle) =
            Seq.append source turtle
        [<CustomOperation("REPEAT", MaintainsVariableSpace = true)>]
        member x.Repeat(source:Turtle, nb:int, times_word:TIMES_word, what_word:WHAT_word, turtle:Turtle, does_word:DOES_word) =
            Seq.append source (List.replicate nb turtle |> Seq.collect id)

    let core = new CoreBuilder()

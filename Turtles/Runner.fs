module Runner

open Turtles

type Command =
    | Reset
    | DoActions of Turtle

type CommandHandler = Command -> unit

[<RequireQualifiedAccess>]
type UnitCommand =
    | Reset
    | DoAction of Action

type UnitCommandHandler = UnitCommand -> unit

let Create unitCommandHandler =
    function
    | Reset -> UnitCommand.Reset |> unitCommandHandler
    | DoActions actions ->
        for action in actions do
        action |> UnitCommand.DoAction |> unitCommandHandler
        Async.Sleep 20 |> Async.RunSynchronously
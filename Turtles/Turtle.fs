namespace Turtles

type Distance_Unit = | STEPS | DOTS with
    member x.ToDots(n) =
        match x with
        | DOTS -> n
        | STEPS -> n * 5
type Rotation_Unit = GRADATIONS
type Rotation_Direction = | LEFT | RIGHT

type Color = | RED | GREEN | BLUE | YELLOW | PINK | ORANGE | PURPLE

type Action =
    | Walk of int * Distance_Unit
    | Turn of int * Rotation_Unit * Rotation_Direction
    | LiftPenUp
    | PutPenDown
    | PickColor of Color with
    member a.IsNoOp =
        match a with
        | Walk(0, _) -> true
        | Turn(n, _, _) when n%24=0 -> true
        | _ -> false

type Turtle = Action seq

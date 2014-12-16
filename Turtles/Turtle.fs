namespace Turtles

type Distance_Unit = | STEPS | DOTS with
    member x.ToDots(n:int) =
        match x with
        | DOTS -> float n
        | STEPS -> (float n) * 5.
type Rotation_Unit = GRADATIONS
type Rotation_Direction = | LEFT | RIGHT

type Color = | RED | GREEN | BLUE

type Action =
    | Walk of int * Distance_Unit
    | Turn of int * Rotation_Unit * Rotation_Direction
    | LiftPenUp
    | PutPenDown
    | PickColor of Color

type Turtle = Action seq

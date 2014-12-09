module Turtles

type Distance_Unit = STEPS
type Rotation_Unit = GRADATIONS
type Rotation_Direction = | LEFT | RIGHT
let STEP = STEPS
let GRADATION = GRADATIONS

type Color = | RED | GREEN | BLUE

type Action =
    | Walk of int * Distance_Unit
    | Turn of int * Rotation_Unit * Rotation_Direction
    | LiftPenUp
    | PutPenDown
    | PickColor of Color

type Turtle = Action seq

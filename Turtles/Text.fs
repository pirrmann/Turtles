namespace Turtles

module Text =
    open Turtles
    open Turtles.DSL.English

    module Letters =
        let Space = turtle {
            LIFT THE PEN UP
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let BackSpace = turtle {
            LIFT THE PEN UP
            TURN 6 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE RIGHT }

        let LineFeed = turtle {
            LIFT THE PEN UP
            TURN 12 GRADATIONS TO THE LEFT
            WALK 6 STEPS
            TURN 12 GRADATIONS TO THE LEFT }

        let A = 
            turtle {
            PUT THE PEN DOWN
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 12 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            LIFT THE PEN UP
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT }

        let B = turtle {
            PUT THE PEN DOWN
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 2 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 2 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 12 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 2 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 2 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 12 GRADATIONS TO THE LEFT
            LIFT THE PEN UP
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let C = turtle {
            PUT THE PEN DOWN
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 12 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            LIFT THE PEN UP
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT }

        let D = turtle {
            PUT THE PEN DOWN
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 2 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 3 STEPS
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 2 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 12 GRADATIONS TO THE RIGHT
            LIFT THE PEN UP
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let E = turtle {
            PUT THE PEN DOWN
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 12 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 12 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            LIFT THE PEN UP
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT }

        let F = turtle {
            PUT THE PEN DOWN
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 12 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 12 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            LIFT THE PEN UP
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let G = turtle {
            PUT THE PEN DOWN
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 12 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 12 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            LIFT THE PEN UP
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT }

        let H = turtle {
            PUT THE PEN DOWN
            WALK 4 STEPS
            TURN 12 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 12 GRADATIONS TO THE LEFT
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            LIFT THE PEN UP
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT }

        let I = turtle {
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            PUT THE PEN DOWN
            WALK 2 STEPS
            TURN 12 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 12 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            LIFT THE PEN UP
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT }

        let J = turtle {
            LIFT THE PEN UP
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            PUT THE PEN DOWN
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 3 STEPS
            TURN 2 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 12 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 10 GRADATIONS TO THE RIGHT
            LIFT THE PEN UP
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT }

        let K = turtle {
            PUT THE PEN DOWN
            WALK 4 STEPS
            TURN 12 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 9 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 12 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 12 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 9 GRADATIONS TO THE LEFT
            LIFT THE PEN UP
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let L = turtle {
            PUT THE PEN DOWN
            WALK 4 STEPS
            TURN 12 GRADATIONS TO THE RIGHT
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            LIFT THE PEN UP
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT }

        let M = turtle {
            PUT THE PEN DOWN
            WALK 4 STEPS
            TURN 10 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 8 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 10 GRADATIONS TO THE RIGHT
            WALK 4 STEPS
            LIFT THE PEN UP
            TURN 12 GRADATIONS TO THE LEFT
            WALK 4 STEPS
            TURN 10 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 8 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 10 GRADATIONS TO THE LEFT
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let N = turtle {
            PUT THE PEN DOWN
            WALK 4 STEPS
            TURN 10 GRADATIONS TO THE RIGHT
            WALK 4 STEPS
            TURN 10 GRADATIONS TO THE LEFT
            WALK 4 STEPS
            LIFT THE PEN UP
            TURN 12 GRADATIONS TO THE RIGHT
            WALK 4 STEPS
            TURN 10 GRADATIONS TO THE RIGHT
            WALK 4 STEPS
            TURN 10 GRADATIONS TO THE LEFT
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let O = turtle {
            LIFT THE PEN UP
            WALK 1 STEP
            PUT THE PEN DOWN
            WALK 2 STEPS
            TURN 2 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 2 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 2 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            LIFT THE PEN UP
            TURN 10 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let P = turtle {
            PUT THE PEN DOWN
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 2 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 2 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            LIFT THE PEN UP
            TURN 6 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let Q = turtle {
            LIFT THE PEN UP
            WALK 1 STEP
            PUT THE PEN DOWN
            WALK 2 STEPS
            TURN 2 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 2 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 2 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 12 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            LIFT THE PEN UP
            TURN 10 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let R = turtle {
            PUT THE PEN DOWN
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 2 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 12 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 4 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            LIFT THE PEN UP
            TURN 6 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let S = turtle {
            LIFT THE PEN UP
            WALK 3 STEPS
            PUT THE PEN DOWN
            TURN 2 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 12 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 5 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 5 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 12 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 5 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            LIFT THE PEN UP
            TURN 9 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let T = turtle {
            LIFT THE PEN UP
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT
            PUT THE PEN DOWN
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 12 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 12 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            LIFT THE PEN UP
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let U = turtle {
            LIFT THE PEN UP
            WALK 1 STEP
            PUT THE PEN DOWN
            WALK 3 STEPS
            TURN 12 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 2 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 2 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 12 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 2 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            LIFT THE PEN UP
            TURN 10 GRADATIONS TO THE LEFT
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let V = turtle {
            LIFT THE PEN UP
            WALK 4 STEPS
            TURN 11 GRADATIONS TO THE RIGHT
            PUT THE PEN DOWN
            WALK 4 STEPS
            TURN 10 GRADATIONS TO THE LEFT
            WALK 4 STEPS
            TURN 12 GRADATIONS TO THE RIGHT
            WALK 4 STEPS
            TURN 10 GRADATIONS TO THE RIGHT
            WALK 4 STEPS
            LIFT THE PEN UP
            TURN 11 GRADATIONS TO THE LEFT
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let W = turtle {
            LIFT THE PEN UP
            WALK 4 STEPS
            TURN 11 GRADATIONS TO THE RIGHT
            PUT THE PEN DOWN
            WALK 4 STEPS
            TURN 10 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 10 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 10 GRADATIONS TO THE LEFT
            WALK 4 STEPS
            TURN 12 GRADATIONS TO THE RIGHT
            WALK 4 STEPS
            TURN 10 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 10 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 10 GRADATIONS TO THE RIGHT
            WALK 4 STEPS
            LIFT THE PEN UP
            TURN 11 GRADATIONS TO THE LEFT
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let X = turtle {
            LIFT THE PEN UP
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 8 GRADATIONS TO THE LEFT
            PUT THE PEN DOWN
            WALK 2 STEPS
            TURN 12 GRADATIONS TO THE LEFT
            WALK 4 STEPS
            TURN 12 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 4 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 12 GRADATIONS TO THE LEFT
            WALK 4 STEPS
            TURN 12 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            LIFT THE PEN UP
            TURN 10 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let Y = turtle {
            LIFT THE PEN UP
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            TURN 8 GRADATIONS TO THE LEFT
            PUT THE PEN DOWN
            WALK 2 STEPS
            TURN 12 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 8 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 12 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 2 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            LIFT THE PEN UP
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let Z = turtle {
            LIFT THE PEN UP
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            PUT THE PEN DOWN
            TURN 4 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 8 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 12 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 8 GRADATIONS TO THE RIGHT
            WALK 4 STEPS
            TURN 8 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 12 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 8 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            LIFT THE PEN UP
            TURN 10 GRADATIONS TO THE RIGHT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let Point = turtle {
            PUT THE PEN DOWN
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            LIFT THE PEN UP
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let Column = turtle {
            PUT THE PEN DOWN
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 1 STEP
            LIFT THE PEN UP
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            PUT THE PEN DOWN
            TURN 6 GRADATIONS TO THE LEFT
            WALK 1 STEP
            LIFT THE PEN UP
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

    let private writeChar char =
        match char with
        | 'A' -> Letters.A
        | 'B' -> Letters.B
        | 'C' -> Letters.C
        | 'D' -> Letters.D            
        | 'E' -> Letters.E
        | 'F' -> Letters.F
        | 'G' -> Letters.G
        | 'H' -> Letters.H
        | 'I' -> Letters.I
        | 'J' -> Letters.J
        | 'K' -> Letters.K
        | 'L' -> Letters.L
        | 'M' -> Letters.M
        | 'N' -> Letters.N
        | 'O' -> Letters.O
        | 'P' -> Letters.P
        | 'Q' -> Letters.Q
        | 'R' -> Letters.R
        | 'S' -> Letters.S
        | 'T' -> Letters.T
        | 'U' -> Letters.U
        | 'V' -> Letters.V
        | 'W' -> Letters.W
        | 'X' -> Letters.X
        | 'Y' -> Letters.Y
        | 'Z' -> Letters.Z
        | '.' -> Letters.Point
        | ':' -> Letters.Column
        | ' ' | _ -> Letters.Space

    let write (text:string) = seq {
        for line in text.Split([|'\n'|]) do
            for char in line do
                yield! writeChar char
            for char in line do
                yield! Letters.BackSpace
            yield! Letters.LineFeed }

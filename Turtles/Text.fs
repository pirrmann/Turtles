namespace Turtles

module Text =
    open Turtles
    open Turtles.DSL.Core

    module Letters =
        let Space = core {
            LIFT THE PEN UP
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let BackSpace = core {
            LIFT THE PEN UP
            TURN 6 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE RIGHT }

        let LineFeed = core {
            LIFT THE PEN UP
            TURN 12 GRADATIONS TO THE LEFT
            WALK 6 STEPS
            TURN 12 GRADATIONS TO THE LEFT }

        let A = 
            core {
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

        let B = core {
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

        let C = core {
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

        let D = core {
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

        let E = core {
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

        let F = core {
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

        let G = core {
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

        let H = core {
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

        let I = core {
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

        let J = core {
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

        let K = core {
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

        let L = core {
            PUT THE PEN DOWN
            WALK 4 STEPS
            TURN 12 GRADATIONS TO THE RIGHT
            WALK 4 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            LIFT THE PEN UP
            WALK 1 STEP
            TURN 6 GRADATIONS TO THE LEFT }

        let M = core {
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

        let N = core {
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

        let O = core {
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

        let P = core {
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

        let Q = core {
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

        let R = core {
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

        let S = core {
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

        let T = core {
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

        let U = core {
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

        let V = core {
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

        let W = core {
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

        let X = core {
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

        let Y = core {
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

        let Z = core {
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

        let Point = core {
            PUT THE PEN DOWN
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 1 DOT
            LIFT THE PEN UP
            WALK 4 DOTS
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let Column = core {
            PUT THE PEN DOWN
            TURN 6 GRADATIONS TO THE RIGHT
            WALK 1 DOT
            LIFT THE PEN UP
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            PUT THE PEN DOWN
            TURN 6 GRADATIONS TO THE LEFT
            WALK 1 DOT
            LIFT THE PEN UP
            TURN 6 GRADATIONS TO THE LEFT
            WALK 2 STEPS
            TURN 6 GRADATIONS TO THE LEFT
            WALK 3 STEPS
            TURN 6 GRADATIONS TO THE LEFT }

        let ExclamationMark = core {
            LIFT THE PEN UP
            WALK 4 STEPS
            TURN 12 GRADATIONS TO THE RIGHT
            PUT THE PEN DOWN
            WALK 2 STEPS
            WALK 4 DOTS
            LIFT THE PEN UP
            WALK 1 STEP
            PUT THE PEN DOWN
            WALK 1 DOT
            LIFT THE PEN UP
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
        | '!' -> Letters.ExclamationMark
        | ' ' | _ -> Letters.Space

    let write (text:string) = seq {
        let lines = text.Split([|'\n'|])
        for line, isLast in lines |> Seq.mapi (fun i line -> line, i = lines.Length-1) do
            for char in line do
                yield! writeChar char
            for char in line do
                yield! Letters.BackSpace
            if not isLast then
                yield! Letters.LineFeed }

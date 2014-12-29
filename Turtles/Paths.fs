module Paths

open Turtles

let merge shortenPaths actions =
    if Seq.isEmpty actions then Seq.empty
    else
        let acc = ref []
        let penDown = ref None

        let getActionsToYield acc =
            let rec shorten path =
                match path with
                | Walk(w1, u1)
                  :: Turn(6, GRADATIONS, d1)
                  :: Walk(w2, u2)
                  :: Turn(6, GRADATIONS, d2)
                  :: Walk(w3, u3)
                  :: tail when d1 = d2 ->
                        let w = u1.ToDots(w1) - u3.ToDots(w3)
                        let mapped =
                            if w > 0 then
                                Walk(w, DOTS)
                                  :: Turn(6, GRADATIONS, d1)
                                  :: Walk(w2, u2)
                                  :: Turn(6, GRADATIONS, d2)
                                  :: tail
                            else
                                Turn(6, GRADATIONS, d1)
                                  :: Walk(w2, u2)
                                  :: Turn(6, GRADATIONS, d2)
                                  :: Walk(-w, DOTS)
                                  :: tail
                        mapped |> shorten
                | head :: tail -> head :: (tail |> shorten)
                | [] -> [] 

            if shortenPaths && !penDown = Some(false) then
                acc |> List.rev |> shorten 
            else
                acc |> List.rev       

        seq {
            for action in actions do
                match !acc, action with
                | _, PutPenDown when !penDown = Some true -> ()
                | _, LiftPenUp when !penDown = Some false -> ()
                | _, PutPenDown ->
                    yield! !acc |> getActionsToYield
                    acc := []
                    yield PutPenDown
                    penDown := Some true
                | _, LiftPenUp ->
                    yield! !acc |> getActionsToYield
                    acc := []
                    yield LiftPenUp
                    penDown := Some false
                | Walk(n1, u1) :: accTail , Walk(n2, u2) ->
                    let newHead = Walk(u1.ToDots(n1) + u2.ToDots(n2), DOTS)
                    acc := if newHead.IsNoOp then accTail else newHead :: accTail
                | Turn(n1, GRADATIONS, d1) :: accTail, Turn(n2, GRADATIONS, d2) ->
                    let n, d = if d1=d2 then n1+n2, d1
                               elif n1>=n2 then n1-n2, d1
                               else n2-n1, d2
                    let newHead = Turn(n, GRADATIONS, d)
                    acc := if newHead.IsNoOp then accTail else newHead :: accTail
                | _ -> acc := action :: !acc
            yield! !acc |> getActionsToYield
        }

let split dotsPerMove gradationsPerMove actions =
    let divRem (x:int) (y:int) = System.Math.DivRem(x, y)
    seq {
        for action in actions do
            match action with
            | Walk(n, u) ->
                let div, rem = divRem (u.ToDots(n)) dotsPerMove
                for i in 1..div do
                    yield Walk(dotsPerMove, DOTS)
                yield Walk(rem, DOTS)
            | Turn(n, GRADATIONS, d) ->
                let div, rem = divRem (n % 24) gradationsPerMove
                for i in 1..div do
                    yield Turn(gradationsPerMove, GRADATIONS, d)
                yield Turn(rem, GRADATIONS, d)
            | _ -> yield action }

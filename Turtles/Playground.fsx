#load "Turtle.fs"
#load "Dsl.Core.fs"
#load "Text.fs"

#load "Runner.fs"
#load "Window.fs"

System.Environment.CurrentDirectory <- __SOURCE_DIRECTORY__

open System.Drawing

let handler = Window.Create() |> Runner.Create

let handleActions = Runner.DoActions >> handler
let reset() = Runner.Reset |> handler

#load "Dsl.English.fs"
#load "Dsl.French.fs"

open Turtles
open DSL.French

let leonardo = tortue {
    AVANCE DE 5 PAS
    TOURNE DE 6 CRANS A DROITE
    AVANCE DE 5 PAS
    TOURNE DE 6 CRANS A DROITE
    AVANCE DE 5 PAS
    TOURNE DE 6 CRANS A DROITE
    AVANCE DE 10 PAS }

let donatello = tortue {
    FAIS COMME leonardo
    FAIS COMME leonardo
    FAIS COMME leonardo
    FAIS COMME leonardo }

let etoile modele =
    let pic = tortue {
        FAIS COMME modele
        TOURNE DE 8 CRANS A DROITE
        FAIS COMME modele
        TOURNE DE 4 CRANS A GAUCHE
    }
    tortue {
        FAIS COMME pic
        FAIS COMME pic
        FAIS COMME pic
        FAIS COMME pic
        FAIS COMME pic
        FAIS COMME pic
    }

let rec segment n =
    let modele = if n % 3 = 0
                 then segment (n/3)
                 else tortue { AVANCE DE n PAS }
    tortue {
        FAIS COMME modele
        TOURNE DE 4 CRANS A GAUCHE
        FAIS COMME modele
        TOURNE DE 8 CRANS A DROITE
        FAIS COMME modele
        TOURNE DE 4 CRANS A GAUCHE
        FAIS COMME modele }

let test = etoile (segment 9)

let french = tortue {
    LEVE LE STYLO
    AVANCE DE 4 PAS
    TOURNE DE 3 CRANS A GAUCHE
    PRENDS LE STYLO VERT
    POSE LE STYLO
    FAIS COMME leonardo
    LEVE LE STYLO
    AVANCE DE 4 PAS
    PRENDS LE STYLO ROUGE
    POSE LE STYLO
    REPETE 3 FOIS CE QUE leonardo FAIT
}

#load "Dsl.English.fs"
open DSL.English

let british = turtle {
    LIFT THE PEN UP
    WALK 4 STEPS
    TURN 3 GRADATIONS TO THE RIGHT
    PICK THE GREEN PEN
    PUT THE PEN DOWN
    DO AS leonardo
    LIFT THE PEN UP
    WALK 4 STEPS
    PICK THE RED PEN
    PUT THE PEN DOWN
    REPEAT 3 TIMES WHAT leonardo DOES
}


// leonardo |> handleActions
// donatello |> handleActions
// test |> handleActions
// british |> handleActions
// french |> handleActions

// [Action.Turn(6, GRADATIONS, LEFT)] |> handleActions
// [Action.Walk(20, STEPS)] |> handleActions
// [Action.PickColor(GREEN)] |> handleActions
// [Action.LiftPenUp] |> handleActions
// [Action.PutPenDown] |> handleActions

let writer = turtle {
    WRITE "MR T. SAYS:\nHELLO WORLD!\n\n"
}
writer |> handleActions

//reset()

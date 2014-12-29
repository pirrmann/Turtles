#load "Turtle.fs"
#load "Dsl.Core.fs"
#load "Text.fs"

#load "Paths.fs"
#load "Commands.fs"
#load "Window.fs"

System.Environment.CurrentDirectory <- __SOURCE_DIRECTORY__

open Turtles
open System.Drawing

let host = Window.Create()

let t = Avatar.Create("t", host)

let handleActions = t.Post
let reset() = Command.Reset |> host.Post

#load "Dsl.English.fs"
#load "Dsl.French.fs"

open Turtles.DSL.English
open Turtles.DSL.French

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

//let writer = turtle {
//    WRITE """
// BONJOUR MARGOT !
//JE SUIS UNE TORTUE.
//VEUX TU JOUER AVEC MOI ?"""
//}
//writer |> handleActions

reset()
let VAS_Y = handleActions
let EFFACE = reset

let zigzag = tortue {
    AVANCE DE 10 PAS
    TOURNE DE 6 CRANS A DROITE
    AVANCE DE 10 PAS
    TOURNE DE 6 CRANS A DROITE
    AVANCE DE 10 PAS
    TOURNE DE 6 CRANS A GAUCHE
    AVANCE DE 10 PAS
    TOURNE DE 6 CRANS A GAUCHE }

let soleil =
    let arc = tortue {
        AVANCE DE 2 PAS
        TOURNE DE 1 CRAN A GAUCHE
    }
    let b = tortue {
        REPETE 2 FOIS CE QUE arc FAIT
        TOURNE DE 6 CRANS A DROITE
        AVANCE DE 6 PAS
        TOURNE DE 12 CRANS A DROITE
        AVANCE DE 6 PAS
        TOURNE DE 6 CRANS A DROITE
        REPETE 2 FOIS CE QUE arc FAIT
        TOURNE DE 6 CRANS A DROITE
        AVANCE DE 10 PAS
        TOURNE DE 12 CRANS A DROITE
        AVANCE DE 10 PAS
        TOURNE DE 6 CRANS A DROITE
    }
    tortue {
        REPETE 6 FOIS CE QUE b FAIT
    }

let porte =
    let arc = tortue {
        AVANCE DE 4 PAS
        TOURNE DE 1 CRAN A GAUCHE
    }
    tortue {
        POSE LE STYLO
        AVANCE DE 30 PAS
        REPETE 12 FOIS CE QUE arc FAIT
        AVANCE DE 34 PAS
    }

let fenetre =
    let arc = tortue {
        AVANCE DE 2 PAS
        TOURNE DE 1 CRAN A GAUCHE
    }
    tortue {
        POSE LE STYLO
        AVANCE DE 20 PAS
        REPETE 12 FOIS CE QUE arc FAIT
        AVANCE DE 22 PAS
        TOURNE DE 6 CRANS A GAUCHE
        AVANCE DE 15 PAS
    }

let paysage = tortue {
    LEVE LE STYLO
    TOURNE DE 6 CRANS A GAUCHE
    AVANCE DE 80 PAS
    TOURNE DE 6 CRANS A DROITE
    PRENDS LE STYLO VERT
    POSE LE STYLO
    REPETE 2 FOIS CE QUE zigzag FAIT
    PRENDS LE STYLO ROUGE
    REPETE 2 FOIS CE QUE zigzag FAIT
    PRENDS LE STYLO BLEU
    REPETE 2 FOIS CE QUE zigzag FAIT
    PRENDS LE STYLO VERT
    REPETE 2 FOIS CE QUE zigzag FAIT
    LEVE LE STYLO
    AVANCE DE 45 PAS
    TOURNE DE 6 CRANS A GAUCHE
    AVANCE DE 120 PAS
    PRENDS LE STYLO ROSE
    POSE LE STYLO
    FAIS COMME soleil
    LEVE LE STYLO
    TOURNE DE 6 CRANS A GAUCHE
    AVANCE DE 105 PAS
    TOURNE DE 6 CRANS A GAUCHE
    AVANCE DE 10 PAS
    TOURNE DE 6 CRANS A GAUCHE
    FAIS COMME porte
    LEVE LE STYLO
    TOURNE DE 6 CRANS A GAUCHE
    AVANCE DE 75 PAS
    TOURNE DE 6 CRANS A GAUCHE
    AVANCE DE 20 PAS
    FAIS COMME fenetre
}

//paysage |> VAS_Y
//
//
//let writer = turtle {
//    WRITE "MR T. SAYS:\nHELLO WORLD!\n\n"
//}
//writer |> handleActions
//
//reset()

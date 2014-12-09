﻿#load "Turtle.fs"
#load "Window.fs"
#load "Dsl.English.fs"
#load "Dsl.French.fs"

System.Environment.CurrentDirectory <- __SOURCE_DIRECTORY__

open System.Drawing

let host = Window.Create()

let handle command =
    let deleg = new System.Action(fun () -> command |> host.Handler)
    host.Form.Invoke(deleg) |> ignore

let handleActions = Window.DoActions >> handle
let reset() = Window.Reset |> handle

host.Form.Show()

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
// triangle |> handleActions
// test |> handleActions
// british |> handleActions
// french |> handleActions
// tortue { TOURNE DE 8 CRANS A GAUCHE } |> handleActions
// turtle { PICK THE GREEN PEN } |> handleActions
reset()
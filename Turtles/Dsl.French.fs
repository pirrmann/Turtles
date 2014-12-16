namespace Turtles.DSL

open Turtles

module French =
    type Tortue = Turtle

    type Unite_De_Distance = PAS with
        member x.enAnglais = match x with | PAS -> STEPS

    type Unite_De_Rotation = | CRANS with
        member x.enAnglais = match x with | CRANS -> GRADATIONS
    let CRAN = CRANS

    type Sens_De_Rotation = | GAUCHE | DROITE with
        member x.enAnglais = match x with
                             | GAUCHE -> LEFT
                             | DROITE -> RIGHT

    type Couleur = | ROUGE | VERT | BLEU with
        member x.enAnglais = match x with
                             | ROUGE -> RED
                             | VERT -> GREEN
                             | BLEU -> BLUE

    type Mot_A = A
    type Mot_DE = DE
    type Mot_LE = LE
    type Mot_STYLO = STYLO
    type Mot_COMME = COMME
    type Mot_FOIS = FOIS
    type Mot_CE = CE
    type Mot_QUE = QUE
    type Mot_FAIT = FAIT

    type TortueBuilder() =
        member x.Yield(()) = Seq.empty
        member x.For(_) = Seq.empty
        [<CustomOperation("AVANCE", MaintainsVariableSpace = true)>]
        member x.Avance(source:Tortue, de:Mot_DE, nb, unite:Unite_De_Distance) =
            Seq.append source [Walk(nb, unite.enAnglais)]
        [<CustomOperation("TOURNE", MaintainsVariableSpace = true)>]
        member x.Tourne(source:Tortue, de:Mot_DE, nb, unite:Unite_De_Rotation, a:Mot_A, sens:Sens_De_Rotation) =
            Seq.append source [Turn(nb, unite.enAnglais, sens.enAnglais)]
        [<CustomOperation("LEVE", MaintainsVariableSpace = true)>]
        member x.Leve(source:Tortue, le:Mot_LE, stylo:Mot_STYLO) =
            Seq.append source [LiftPenUp]
        [<CustomOperation("POSE", MaintainsVariableSpace = true)>]
        member x.Pose(source:Tortue, le:Mot_LE, stylo:Mot_STYLO) =
            Seq.append source [PutPenDown]
        [<CustomOperation("PRENDS", MaintainsVariableSpace = true)>]
        member x.Prends(source:Tortue, le:Mot_LE, stylo:Mot_STYLO, couleur:Couleur) =
            Seq.append source [PickColor couleur.enAnglais]
        [<CustomOperation("FAIS", MaintainsVariableSpace = true)>]
        member x.Fais(source:Tortue, comme:Mot_COMME, tortue:Tortue) =
            Seq.append source tortue
        [<CustomOperation("REPETE", MaintainsVariableSpace = true)>]
        member x.Repete(source:Tortue, nb:int, fois:Mot_FOIS, ce:Mot_CE, que:Mot_QUE, tortue:Tortue, fait:Mot_FAIT) =
            Seq.append source (List.replicate nb tortue |> Seq.collect id)

    let tortue = new TortueBuilder()

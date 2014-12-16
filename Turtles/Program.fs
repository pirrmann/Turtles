open System
open System.Drawing
open System.Windows.Forms

open Turtles.Text

[<EntryPoint>]
[<STAThread>]
let main argv = 
    let handler = Window.Create() |> Runner.Create

    write "HELLO WORLD" |> Runner.DoActions |> handler

    0 // return an integer exit code
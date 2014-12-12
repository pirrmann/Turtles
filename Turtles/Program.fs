open System
open System.Drawing
open System.Windows.Forms

[<EntryPoint>]
[<STAThread>]
let main argv = 
    Window.Create() |> ignore
    0 // return an integer exit code
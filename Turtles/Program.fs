open System
open System.Drawing
open System.Windows.Forms

[<EntryPoint>]
[<STAThread>]
let main argv = 

    let host = Window.Create()

    async {
        do! Async.Sleep 100
        do Window.Reset |> host.Handler
    } |> Async.StartImmediate

    Application.Run(host.Form)

    0 // return an integer exit code

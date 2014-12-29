namespace Turtles

open Turtles

type Command =
    | Close
    | Reset
    | DoAction of Avatar * Action

and Avatar = Avatar of string with
    static member Create(name, host:MailboxProcessor<Command>) : MailboxProcessor<Turtle> =
        let dotsPerMove = 15
        let graduationsPerMove = 4
        let avatar = Avatar(name)
        MailboxProcessor.Start(fun inbox -> 
            let rec loop () = async { 
                let! actions = inbox.Receive()
                for action in actions |> Paths.merge true |> Paths.split dotsPerMove graduationsPerMove do
                    host.Post(DoAction(avatar, action))
                    do! Async.Sleep 20
                return! loop() }                   
            loop())

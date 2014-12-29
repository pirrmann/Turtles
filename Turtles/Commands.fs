namespace Turtles

open Turtles

type Command =
    | Close
    | Reset
    | DoAction of Avatar * Action

and Avatar = Avatar of string * Color option with
    static member Create(name, host:MailboxProcessor<Command>, ?color, ?dotsPerMove, ?gradationsPerMove, ?sleepTime) : MailboxProcessor<Turtle> =
        let dotsPerMove = defaultArg dotsPerMove 15
        let gradationsPerMove = defaultArg gradationsPerMove 4
        let sleepTime = defaultArg sleepTime 20
        let avatar = Avatar(name, color)
        MailboxProcessor.Start(fun inbox -> 
            let rec loop () = async { 
                let! actions = inbox.Receive()
                for action in actions |> Paths.merge true |> Paths.split dotsPerMove gradationsPerMove do
                    host.Post(DoAction(avatar, action))
                    do! Async.Sleep sleepTime
                return! loop() }                   
            loop())

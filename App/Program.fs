﻿module Program

open System
open Day1  

let readInput () =
    Console.WriteLine("Select day to run:")
    Console.ReadLine()  

[<EntryPoint>]
let main argv =
    let day = readInput()

    match day with
    | "Day1" -> 
        let result = Day1.run()  
        printfn "Day1 result: %A" result
    | _ -> 
        printfn "Invalid day selected."

    0 

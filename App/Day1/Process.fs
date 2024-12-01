module Day1

open System
open Input

let run () = 
    let data = getInput()
    let unfilteredData = data.Split([| ' '; '\n' |])
    let filteredData = unfilteredData |> Array.filter(fun number -> number <> "")
    let firstList = filteredData |> Array.filter(fun number -> number |> )
    
    for e in filteredData do
        printfn $"%A{e}"


let getListFromCombined (order: String, list: Array ) =
    match order with
    | "first" ->
        let mutable firstList = []
        let mutable count = 0
        for item in list do
            count++
            
    | "second" ->
        
    | _ ->
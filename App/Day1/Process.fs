module Day1

open System
open Input

let run () = 
    let data = getInput()
    let unfilteredData = data.Split([| ' '; '\n' |])
    let filteredData = unfilteredData |> Array.filter(fun number -> number <> "")
    
    let splitArray (arr: string[]) =
        let firstArray = [| for i in 0 .. 2 .. arr.Length - 1 -> arr.[i] |]
        let secondArray = [| for i in 1 .. 2 .. arr.Length - 1 -> arr.[i] |]
        (firstArray, secondArray)

    let (firstList, secondList) = splitArray filteredData
    
    let firstListSorted = Array.sort firstList
    let secondListSorted = Array.sort secondList
    
    let firstIntListSorted = Array.map int firstListSorted 
    let secondIntListSorted = Array.map int secondListSorted
    
    let diffArray = Array.map2 (fun first second -> abs (first - second)) firstIntListSorted secondIntListSorted

    Array.sum diffArray

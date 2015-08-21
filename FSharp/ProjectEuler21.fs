open System

// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

let data = [1..300]

let findDivisor number = 
    let upperBound = int(number / 2)
    [1..(upperBound + 1)] |> List.filter(fun x -> number % x = 0)

let d(num) =
    (findDivisor num) |> List.sum

let rec searchAmicableNumbers num acc =
    match num with
    |num when num = 1 -> acc
    |num when(num = d(d(num))) && (d(num) <> num) -> searchAmicableNumbers (num - 1) acc@[num]
    |_ -> searchAmicableNumbers (num - 1) acc
 
             
    

[<EntryPoint>]
let main argv = 
    let res = searchAmicableNumbers 10000 [] |> List.sum
    printfn "%A" res
    0 // return an integer exit code

let list = [1..20]

let sumSquare = list |> List.sumBy(fun x -> x * x)

let squareSum = (float (list |> List.sum)) ** 2.0

[<EntryPoint>]
let main argv = 
    let result = int squareSum - sumSquare
    printfn "%A" result

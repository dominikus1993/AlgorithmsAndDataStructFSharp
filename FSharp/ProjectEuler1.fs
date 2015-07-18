
let list = [1..1000]

let sum data = data |> List.filter(fun x->x % 5 = 0 || x % 3 = 0) |> List.sum

[<EntryPoint>]
let main argv =
    let result = sum list
    printfn "%A" result
    0 // return an integer exit code
let list = [1..100]
 
[<EntryPoint>]
let main argv = 
    let result = list |> List.sumBy(fun _ -> 1)
    printfn "%A" result
    0 // return an integer exit code
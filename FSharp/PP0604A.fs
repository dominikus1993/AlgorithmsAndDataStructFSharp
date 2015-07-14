
let list = [1..1111]

let sum data = data |> List.sum

let avg (data:List<int>,func) = (func data) / data.Length
    
 

 
[<EntryPoint>]
let main argv =
    let result = avg(list,sum)
    printfn "%A" result
    0 // return an integer exit code
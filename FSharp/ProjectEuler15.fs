// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
let rec sequence num acc =  
    match num with
    |num when num = 1 -> acc
    |num when num % 2 = 0 -> sequence (num/2) (acc @ [num / 2])
    |_ -> sequence (3 * num + 1) (acc @ [ 3 * num + 1])


let rec seqLengths from too acc =
    match from with
    |from when from = too -> acc 
    |_-> seqLengths (from + 1) too (acc @ [sequence from])  

[<EntryPoint>]
let main argv = 
    let res = seqLengths  1000000 |> List.max 
    printfn "%A" res
    0 // return an integer exit code

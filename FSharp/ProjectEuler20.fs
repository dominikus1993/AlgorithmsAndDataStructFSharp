open System

// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
let rec factorial n =     
    if n = 0I then
        1I
    else 
        factorial(n - 1I) * n

[<EntryPoint>]
let main argv = 
    let res = factorial(100I).ToString() |> Seq.map(fun x -> Int32.Parse(x.ToString())) |> Seq.sum
    printfn "%A" res
    0 // return an integer exit code

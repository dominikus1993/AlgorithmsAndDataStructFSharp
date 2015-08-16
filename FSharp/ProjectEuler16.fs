// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System
let first = 2I
let last = bigint (2.0 ** 1000.0)
let sumArythmeticSeq (a1:bigint, an:bigint, n:bigint) = (((a1 + an) / 2I) * n).ToString()
let data list = [for x in list -> x]
[<EntryPoint>]
let main argv = 
    let res = data (sumArythmeticSeq(first, last, 1000I)) |> Seq.map(fun x -> Int32.Parse(x.ToString()))
    printfn "%A" (res |> Seq.sum)
    0 // return an integer exit code

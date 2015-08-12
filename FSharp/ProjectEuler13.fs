
open System.IO

let sum = 
    File.ReadAllLines(@"C:\Users\domin_000\Documents\Visual Studio 2015\Projects\TestFSharp\TestFSharp\euler.txt")
    |> Seq.map(fun x -> bigint.Parse(x))
    |> Seq.sum
    
let res = sum.ToString().Substring(0,10)

[<EntryPoint>]
let main argv =
    let result = res 
    printfn "%A" result
    0 // return an integer exit code

open System.IO

let numbers =
    File.ReadAllLines(@"C:\Users\domin_000\Documents\Visual Studio 2015\Projects\TestFSharp\TestFSharp\euler.txt")
    |> Seq.concat
    |> Seq.map(fun x -> int32(x.ToString()))

let func list = list |> Seq.fold(fun acc (x) -> acc * x) 1
[<EntryPoint>]
let main argv = 
    let result = numbers |> Seq.windowed(13) |> Seq.map(func) |> Seq.max
    printfn "%A" result
    0

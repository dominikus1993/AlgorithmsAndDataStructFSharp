let sum = [1I..1000I] |> Seq.map(fun x -> x ** (int x)) |> Seq.sum
[<EntryPoint>]
let main args =
    let res = sum.ToString().Substring((sum.ToString().Length - 10),10)
    printf "%A" res
    0

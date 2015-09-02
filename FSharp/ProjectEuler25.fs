open System

let fibSeq = Seq.unfold(fun (x,y) -> Some(x,(x + y, x))) (0I,1I) |> Seq.takeWhile(fun x -> x.ToString().ToCharArray().Length  <> 1000)

[<EntryPoint>]
let main argv =
    //let smallabutantNumber = [1..28123] |> List.filter(fun x -> isAbutant(x,findFactor))
    let res = fibSeq |> Seq.length
    printfn "%A" res
    0 // return an integer exit code

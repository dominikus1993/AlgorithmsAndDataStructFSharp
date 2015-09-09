open System

let fibSeq = Seq.unfold(fun (x,y) -> Some(x,(x + y, x))) (0I,1I) |> Seq.takeWhile(fun x -> x.ToString().ToCharArray().Length  <> 1000)
open System.Linq

let numbers = List.unfold(fun (x, y) -> if y < 1000.0 then Some(x,(1.0 / y, y + 1.0)) else None) (1.0,2.0)

[<EntryPoint>]
let main argv =
    //let smallabutantNumber = [1..28123] |> List.filter(fun x -> isAbutant(x,findFactor))
    let res1 = numbers |> List.tail|> List.map(fun x -> x.ToString().Split(',').[1].ToCharArray().Distinct().Count())
    let max = res1 |> List.max
    let index = res1 |> List.findIndex(fun x -> x = max);
    printfn "%A" (index + 2)
    0 // return an integer exit code

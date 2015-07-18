
let fibSeq = Seq.unfold(fun(x,y)-> Some(x,(y,x + y)))(0,1)

let fib = fibSeq |> Seq.takeWhile(fun x -> x < 40000000) |> Seq.filter(fun x -> x % 2 = 0) |> Seq.sum 

[<EntryPoint>]
let main argv =
    let result = fib
    printfn "%A" result
    0 // return an integer exit code
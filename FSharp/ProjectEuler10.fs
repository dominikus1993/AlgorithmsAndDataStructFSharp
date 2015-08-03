let isPrime number = [2L..( int64(sqrt (double number)))] |> List.filter(fun x -> number % x = 0L) |> List.length = 0

let primeSeq = Seq.unfold(fun(x)-> Some(x, x+1L))(2L) |> Seq.takeWhile(fun x -> x < 2000000L) |> Seq.filter(isPrime) 

[<EntryPoint>]
let main argv =
    let result = primeSeq |> Seq.sum
    printfn "%A" result
    0 // return an integer exit code

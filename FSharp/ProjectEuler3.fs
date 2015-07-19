open System 

let findFactor (number:int64) = 
    let upperBound = int64(sqrt (double number))
    [2L..upperBound] |> Seq.filter(fun x -> number % x = 0L)

let isPrime(n:int64) =  (findFactor(n) |> Seq.length) = 0

let filterList (number:int64) =
        let upperBound = int64(sqrt (double number))
        [2L..upperBound] |> Seq.filter(fun x -> number % x = 0L) |> Seq.filter(fun x -> isPrime(x)) |> Seq.max

[<EntryPoint>]
let main argv =
    let result = filterList(600851475143L)
    printfn "%A" result
    0 // return an integer exit code
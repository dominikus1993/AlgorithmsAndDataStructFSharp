open System

let isPrime(number) = ([2..int(sqrt (double number))] |> Seq.filter(fun x -> number % x = 0) |> Seq.length ) = 0

let listGen = Seq.unfold(fun x -> Some(x,x + 1)) 2 |> Seq.filter(isPrime) 

let nth number= listGen |> Seq.nth(number)

[<EntryPoint>]
let main argv = 
    let result = nth 10000
    printfn "%A" result
    0 // return an integer exit code


let rec fib = function
    |0 -> 0
    |1 -> 1
    |n -> fib(n - 1) + fib(n - 2)
     
[<EntryPoint>]
let main argv =
    let result = fib 5
    printfn "%A" result
    0 // return an integer exit code

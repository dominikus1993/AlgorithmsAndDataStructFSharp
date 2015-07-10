
let rec factorial = function
    |0 -> 1
    |n -> factorial(n - 1) * n
     
[<EntryPoint>]
let main argv =
    let result = factorial 5
    printfn "%A" result
    0 // return an integer exit code

// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
let rec factorial(n:bigint) = 
    if n = 0I then 1I
    else
        n * factorial(n  - 1I)    

let combination (n, k) = factorial(n)  / ((factorial k) * (factorial (n - k))) 
[<EntryPoint>]
let main argv = 
    let res = combination (40I, 20I)
    printfn "%A" res
    0 // return an integer exit code

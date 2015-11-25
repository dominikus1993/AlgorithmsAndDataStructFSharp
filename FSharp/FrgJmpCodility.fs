
let rec solve(startVal, dVal, endVal, count) = 
    if startVal >= endVal then
        count
    else
        solve(startVal + dVal, dVal, endVal, count + 1)
     

let solution(x, y, d) =
    solve(x, d, y, 0)



[<EntryPoint>]
let main argv = 
    let result = solution(10,850000000,30)
    printfn "%A" result
    0 

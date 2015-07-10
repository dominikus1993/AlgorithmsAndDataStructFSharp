
let rec pascalTriangle(n:int ,k:int)=
    if n = k or k = 0
        then 1
    else 
         pascalTriangle(n - 1, k) + pascalTriangle(n - 1, k - 1)
     
[<EntryPoint>]
let main argv =
    let result = pascalTriangle(3,2)
    printfn "%A" result
    0 // return an integer exit code

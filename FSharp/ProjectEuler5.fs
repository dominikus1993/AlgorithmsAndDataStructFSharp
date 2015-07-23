let listNumber = [2..20]

let rec findSmallestNumberDividedByWholeNumberFrom1To20 n listNumber=
    if  listNumber |> List.exists(fun x -> n % x <> 0) then
         findSmallestNumberDividedByWholeNumberFrom1To20 (n + 1) listNumber
    else
         n

[<EntryPoint>]
let main argv = 
    let result = findSmallestNumberDividedByWholeNumberFrom1To20 2 listNumber
    printfn "%A" result
    0 // return an integer exit code

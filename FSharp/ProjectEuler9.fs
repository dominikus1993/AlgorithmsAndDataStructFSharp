
let list = 
    seq{
        for a = 0 to 1000 do
            for b = 0 to 1000 do
                for c = 0 to 1000 do
                     if (a + b + c) = 1000 then yield [a;b;c]    
    }

let isPythagoreantriplet (data: int list) =
    match data |> List.sort with
    |[a;b;c]-> a*a + b*b = c*c
    |_-> false

[<EntryPoint>]
let main argv =
    let result = list |> Seq.filter isPythagoreantriplet |> Seq.head |> Seq.fold(fun acc x-> acc * x) 1
    printfn "%A" result
    0 // return an integer exit code

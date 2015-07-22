let toCharArray (text:string)= [for x in text -> x]

let list  = [for x in 100..999 do
     for y in 100..999 do
     yield x*y]  |> List.filter(fun x -> (toCharArray(x.ToString()) |> List.rev) = toCharArray(x.ToString())) |> List.max


[<EntryPoint>]
let main argv = 
    let result = list
    printfn "%A" result
    0 // return an integer exit code

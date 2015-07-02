let charArray text = [for i in text  ->  i] 
let list = ["Visca el Barca"] |> List.collect(fun x -> charArray x)
 
[<EntryPoint>]
let main argv = 
    let result = list |> List.rev 
    printfn "%A" result
    0 // return an integer exit code
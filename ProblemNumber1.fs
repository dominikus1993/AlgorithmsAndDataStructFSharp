// count match items in the list for those defined char
let list = [ 1..100 ]


[<EntryPoint>]
let main argv = 
    let result = list |> List.rev |> List.head
    printfn "%A" result 
    0 // return an integer exit code

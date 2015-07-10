// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
 
let charArray text = [for i in text  ->  i] 
let list = ["potop"] |> List.collect(fun x -> charArray x)
let isPalindrom collection = collection = (collection |> List.rev)
[<EntryPoint>]
let main argv = 
    let result = isPalindrom list 
    printfn "%A" result
    0 // return an integer exit code

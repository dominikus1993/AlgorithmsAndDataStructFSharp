
let list = ['a';'a';'a';'b';'b';'b';'c';'c';'c';'c']

let rec compress' = function
|[]->[]
|head::tail -> List.fold(fun x y -> if y = List.head x then x else y::x) [head] tail |> List.rev
    
 

 
[<EntryPoint>]
let main argv =
    let result = compress' list
    printfn "%A" result
    0 // return an integer exit code
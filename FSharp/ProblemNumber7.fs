
let list = [[1];[2;3;4];[1]];

type 'a NestedList = List of 'a NestedList list | Elem of 'a

let rec flatten ls = 
   let rec loop = List.collect(function 
   |Elem ls -> [ls]
   |List xs -> loop xs) 
   loop[ls] 

 
[<EntryPoint>]
let main argv =
    let result = flatten (List [Elem 1; List [Elem 2; List [Elem 3; Elem 4]; Elem 5]])
    printfn "%A" result
    0 // return an integer exit code
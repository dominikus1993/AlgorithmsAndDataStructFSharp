// count match items in the list for those defined char
let list = [ 1..100 ]

let rec nth' (collection, n) = 
    match collection,n with 
   |[],_ -> 0
   |x::_,1 -> x
   |_::collection,n -> nth'(collection,(n-1)) 



[<EntryPoint>]
let main argv = 
    let result = nth'(list, 6)
    printfn "%A" result 
    0 // return an integer exit code

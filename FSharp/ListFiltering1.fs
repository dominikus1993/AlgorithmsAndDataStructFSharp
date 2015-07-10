//Chose e or c letter from list
let list = ['a';'b';'c';'d';'e']
     
[<EntryPoint>]
let main argv =
    let result = list|>List.filter(fun x -> x = 'd' || x = 'e')
    printfn "%A" result
    0 // return an integer exit code

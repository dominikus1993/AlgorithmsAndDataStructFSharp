//Chose e or c letter from list
let list = ['a'..'e']
     
[<EntryPoint>]
let main argv =
    let result = list|>List.filter(fun x -> x = 'd' || x = 'e')
    printfn "%A" result
    0 // return an integer exit code

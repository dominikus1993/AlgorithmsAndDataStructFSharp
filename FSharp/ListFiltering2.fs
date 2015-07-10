//Create list with snumber to power two and leave number divided by 3
let NumbersPow = [ for x in 1 .. 10->x*x]
let list = NumbersPow|>List.filter(fun x->x%3 = 0)
[<EntryPoint>]
let main argv =
    let result = list
    printfn "%A" result
    0 // return an integer exit code

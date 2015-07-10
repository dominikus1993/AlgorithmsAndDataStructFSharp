//Create List from 1 to 100, leave numbers greter tha  and sort so that even number were in top of the list
let NumbersPow = [ for x in 1 .. 100->x]
let list = NumbersPow|>List.filter(fun x->x > 50)
let sort(number1:int)(number2:int) = 
    if(number1%2 = 0)
        then -1
    else if(number2%2 = 0)
        then 1
    else 
        0

[<EntryPoint>]
let main argv =
    let result = List.sortWith sort list
    printfn "%A" result
    0 // return an integer exit code

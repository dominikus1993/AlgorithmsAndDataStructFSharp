//create list numbers from 1 to 100, sort witch  second number and leave head of list smaller than 90
let NumbersPow = [ for x in 1 .. 100->x]
let list = NumbersPow
let sort(number1:int)(number2:int) = 
    if(number1%10 > number2%10)
        then -1
    else if(number1%10 < number2%10)
        then 1
    else 
        0

[<EntryPoint>]
let main argv =
    let result = List.sortWith sort list |> List.toSeq |> Seq.takeWhile(fun x -> x < 90) |> Seq.toList
    printfn "%A" result
    0 // return an integer exit code

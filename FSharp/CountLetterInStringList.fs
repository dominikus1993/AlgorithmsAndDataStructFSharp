// count match items in the list for those defined char
let list = ["aaaa";"dupa";"ala ma kota"]

let toCharArray (text:string)=
    [for x in text -> x]

let CountCharInList (list:List<string>,letter:char,func) =
    list |> List.sumBy( fun x-> func(x) |> List.filter(fun y-> y = letter) |> List.length )
[<EntryPoint>]
let main argv =
    let result = CountCharInList(list,'a',toCharArray)
    printfn "%A" result
    0 // return an integer exit code

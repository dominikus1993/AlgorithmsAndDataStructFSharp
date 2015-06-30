// use function simmilar flatMap in scala lang so that whole element of list were double
let NumbersPow = [ for x in 1 .. 100->x]
let list = [1 .. 10]

[<EntryPoint>]
let main argv =
    let result = list |> List.collect(fun x -> [x;x])
    printfn "%A" result
    0 // return an integer exit code

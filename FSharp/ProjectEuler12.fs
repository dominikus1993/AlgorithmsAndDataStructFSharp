let triangularNumbers = Seq.unfold(fun (x,y) -> Some(x,(x + y, y + 1L))) (0L, 1L)

let rec getFactors (number:int64) (first:int64) acc=
    match first with
    | first when first > (number / first) || first > (number / 2L) -> acc
    | first when number % first = 0L  -> getFactors number ((first + 1L)) (acc @ if first = (number / first) then [first] else [(first);(number / first)] )
    | _ -> getFactors number (first + 1L) (acc @ [])

let countFactor number:int64 =  int64(getFactors number 1L [] |> List.length)

[<EntryPoint>]
let main argv =
    let result = triangularNumbers |> Seq.filter(fun x -> countFactor x > 500L) |> Seq.head
    printfn "%A" result
    0 // return an integer exit code

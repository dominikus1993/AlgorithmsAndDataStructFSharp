let area (l, w, h) = 
   let min  = [l; w; h] |> List.sort |> List.take(2) |> List.fold(fun acc x -> acc * x) 1
   2 * l * w + 2 * w * h + 2 * h * l + min

[<EntryPoint>]
let main args = 
    let res = area(1,1,10)
    printf "%A" res
    0

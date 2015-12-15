let floor (txt:string) = 
    let up = txt.ToCharArray() |> Array.filter(fun x -> x = '(') |> Array.length
    let down = txt.ToCharArray() |> Array.filter(fun x -> x = ')') |> Array.length
    up - down

[<EntryPoint>]
let main args = 
    printf "%A" (floor "(()(()(")
    0

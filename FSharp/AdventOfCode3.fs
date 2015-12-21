// count match items in the list for those defined char
let turns (c:char) = 
    match c with
    |'^' -> (0,1)
    |'v' -> (0,-1)
    |'<' -> (-1,0)
    |'>' -> (1,0)
    |_ -> (0,0)

let countTurns (text:string) =
    let result = [for x in text.ToCharArray() -> turns(x)]
    result

let turnsPositions (turns:(int * int) list)=
    let x = 0
    let y = 0
    let rec position (list:(int * int) list , xpos:int, ypos:int, acc:(int * int) list) = 
        match list with
        |[] -> acc
        |(a, b)::tail -> position(tail, xpos + a , ypos + b, acc @ [(xpos + a, ypos + b)])
    position(turns, x, y, [(0,0)])
     
let rec distinct (list:(int * int) list , acc:(int * int) list) = 
    match list with
    |[] -> acc
    |(x, y)::tail when not (acc |> List.exists(fun (a,b) -> a = x && b = y)) ->  distinct(tail, acc @ [(x, y)])
    |(x, y)::tail -> distinct(tail, acc)

[<EntryPoint>]
let main argv =
    let turns = countTurns("><><><><><><")
    let result = distinct(turnsPositions(turns), []) |> List.length
    printfn "%A" result
    0 // return an integer exit code

type City = {nr:int; x:float; y:float}

let randLocation n =
    let rnd = System.Random()
    List.init n (fun x -> (x, rnd.NextDouble(), rnd.NextDouble()))    

let citiesGenerator n = 
    let res = randLocation n |> List.map(fun (nr, x, y) -> {nr = nr; x = x; y = y})
    res

let countCost (cities:City[]) =
    let mutable res = 0.0
    for i = 1 to cities.Length - 1 do
        res <- res + ((cities.[i - 1].x) ** (cities.[i].x)) + ((cities.[i - 1].y) ** (cities.[i].y)) 
    sqrt res  

let searchOptimalWayBetweenCities n = 
    let cities = citiesGenerator n
    let rec searcher (nodes:City list, acc: City list) =
        match nodes with
        | [] -> acc
        | head::tail -> 
            let costWithHead = countCost ((head :: acc) |> List.toArray)
            let anythinHasBetterCost = tail |> List.exists(fun x -> (countCost ((x :: acc) |> List.toArray)) < costWithHead)
            if  anythinHasBetterCost then
                searcher((tail @ [head]),acc)
            else
                searcher(tail, head :: acc)
                                                  
    searcher(cities, [])
    
let res = searchOptimalWayBetweenCities 5


open System.IO

let array = 
    File.ReadAllLines(@"C:\Users\domin_000\Documents\Visual Studio 2015\Projects\TestFSharp\TestFSharp\euler.txt")
    |> Seq.map(fun x -> x.Split(' ') |> Seq.map int32 |> Seq.toArray)
    |> Seq.toArray

let height, width = array.Length, array |> Seq.map(fun x -> x.Length) |> Seq.max
let twoD = Array2D.init height width (fun x y -> array.[x].[y])

let up (array:int32[,]) h w element = 
    let dest = h - (element - 1)
    let src = h
    if dest < 0 || src > height - 1 then []
    else [dest..src] |> List.map(fun x -> array.[x, w])

let down (array:int32[,]) h w element = 
    let dest = h  + (element - 1)
    let src = h
    if dest > height - 1 then []
    else [src..dest] |> List.map(fun x -> array.[x,w])

let left (array:int32[,]) h w element = 
    let dest = w - (element - 1)
    let src = w
    if dest < 0  || src > width - 1 then []
    else [dest..src] |> List.map(fun x -> array.[h,x])

let right (array:int32[,]) h w element = 
    let dest = w + (element - 1)
    let src = w
    if dest < 0  || src > width - 1 then []
    else [src..dest] |> List.map(fun x -> array.[h,x])

let rightUp (array:int32[,]) h w element = 
    let indexes = [for x in (h - (element - 1))..h do for y in w..(w + (element - 1)) do if abs (x + y) = abs(h + w) then yield (x, y)]
    if (h > height - 1 || w > width - 1 ) || indexes |> List.length < element || indexes |> List.exists(fun (x,y) -> x < 0 || y > width - 1)  then []
    else seq {for (i,j) in indexes do yield array.[i,j]} |> Seq.toList

let rightDown (array:int32[,]) h w element = 
    let indexes = [for x in h..(h + (element - 1)) do for y in w..(w + (element - 1)) do if abs (x - y) = abs(h - w) then yield (x, y)]
    if (h > height - 1 || w > width - 1 ) || indexes |> List.length < element || indexes |> List.exists(fun (x,y) -> x > height - 1 || y > width - 1)  then []
    else seq {for (i,j) in indexes do yield array.[i,j]} |> Seq.toList

let leftUp (array:int32[,]) h w element = 
    let indexes = [for x in (h - (element - 1))..h do for y in (w - (element - 1))..w do if abs (x - y) = abs(h - w) then yield (x, y)]
    if (h > height - 1 || w > width - 1 ) || indexes |> List.length < element || indexes |> List.exists(fun (x,y) -> x < 0 || y < 0)  then []
    else seq {for (i,j) in indexes do yield array.[i,j]} |> Seq.toList

let leftDown (array:int32[,]) h w element = 
    let indexes = [for x in h..(h + (element - 1)) do for y in (w - (element - 1))..w do if abs (x + y) = abs(h + w) then yield (x, y)]
    if (h > height - 1 || w > width - 1 ) || indexes |> List.length < element || indexes |> List.exists(fun (x,y) -> x > height - 1 || y < 0)  then []
    else seq {for (i,j) in indexes do yield array.[i,j]} |> Seq.toList

let maxProduct (array:int32[,]) el = 
    seq{
        for i = 3 to height - 1 do
            for j = 3 to width - 1 do 
                yield [left array i j el;right array i j el;up array i j el; down array i j el;rightUp array i j el;rightDown array i j el; leftUp array i j el; leftDown array i j el ]  |> Seq.max
       } |> Seq.map(fun x -> x |> List.fold(fun acc y -> acc * y ) 1) 

[<EntryPoint>]
let main argv =
    let result = (maxProduct (twoD) 4) |> Seq.max
    printfn "%A" result
    0 // return an integer exit code

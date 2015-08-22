open System.IO

// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

let myMap = 
    ['A',1;
     'B',2;
     'C',3;
     'D',4;
     'E',5;  
     'F',6;
     'G',7;
     'H',8;
     'I',9;
     'J',10;
     'K',11;
     'L',12;
     'M',13;
     'N',14;
     'O',15;
     'P',16;
     'Q',17;
     'R',18;
     'S',19;
     'T',20;
     'U',21;
     'V',22;
     'W',23;
     'X',24;
     'Y',25;
     'Z',26;
     '"',0;
     ' ',0;
    ]|>Map.ofList

let myToCharArray(word:string) =
    [for x in word -> x] 
let sumLetterPositions (word:string, func:(string -> char list))= 
    let positions = func(word) |> List.map(fun x -> myMap.[x])
    positions  |> List.sum

let nameList = 
    File.ReadAllLines(@"C:\Users\domin_000\Documents\Visual Studio 2015\Projects\TestFSharp\TestFSharp\euler2.txt").[0].Split(',') |> Array.toList
 
let rec getResult (list,func) =
    list |> List.map(fun x -> func(x,myToCharArray))
        
           
[<EntryPoint>]
let main argv = 
    let res = getResult(nameList ,sumLetterPositions) |> List.sum
    printfn "%A" res
    0 // return an integer exit code 

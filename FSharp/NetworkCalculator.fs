open System

//let factorial = fun n -> [1..n] |> List.fold(fun x acc -> x * acc) 1;';'

let rec intToBinary num = 
    match num with
    |0|1 -> string num
    |_ -> 
        let bit = string (num % 2)
        (intToBinary(num / 2)) + bit  

let ipToBinaryArray (text:string, binaryConverter:(int -> string)) =
    text.Split('.') |> Array.map(fun x -> if binaryConverter(int x).Length = 8 then binaryConverter(int x) else  "0" + binaryConverter(int x))
     
let binToDec numbers =
    [for (x,y) in List.zip numbers ([0..(numbers.Length - 1)] |> List.rev)-> Int32.Parse(x.ToString()) * int (2.0 ** (float y))] |> List.sum

let maskGenerator (num:int) = 
    (System.String.Join("",[for x in [1..35] -> if x % 9 = 0 then '.' else if x <= (num + 3)  then '1' else '0'])).Split('.')


let calc (binaryMask:char list,binaryAddress:char list,filter:(char * char -> bool)) = 
    [for x,y in (List.zip binaryMask binaryAddress) -> if x = '.' || y = '.' then '.' else if filter(x,y) then '1' else '0' ] |> List.fold(fun acc x -> acc + x.ToString()) ""

let maskOperations(mask, func) = 
    [for x in mask -> func(x)]

let binaryOperation (mask:char list, number, func) = 
    let res = intToBinary(func(binToDec(mask), number)).ToCharArray() |> Array.toList
    System.String.Join("", [for x in [1..(8 - res.Length)] -> '0'] @ res)
 
[<EntryPoint>]
let main argv =
    let data  = "212.191.99.64 27".Split(' ')
    let binaryAddress = System.String.Join(".",ipToBinaryArray(data.[0], intToBinary)).ToCharArray() |> Array.toList
    let binaryMask = System.String.Join(".", maskGenerator(Int32.Parse(data.[1]))).ToCharArray() |> Array.toList
    let data = "10100000".ToCharArray() |> Array.toList
    let networkAddress = binaryOperation(("00000011".ToCharArray() |> Array.toList), 1, fun (x,y) -> x - y)   //calc(binaryAddress, maskOperations(binaryMask,fun x -> if x = '1' then '0' else if x = '0' then '1' else x),fun (x,y) -> x = '1' || y = '1')
    printfn "%A" networkAddress
    0 // return an integer exit code

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
let alphabet = "abcdefghijklmnopqrstuvwxyz"

let hasVowel (text:string, count:int) = 
    text.ToCharArray() |> Array.filter(fun x -> x = 'a' || x = 'e' || x = 'i' || x = 'o' || x = 'u') |> Array.length >= 3

let createParalellCharSeqence(text:string) =
    let textSeq = text.ToCharArray() |> Array.toSeq
    let helperText = textSeq |> Seq.skip(1)
    textSeq |> Seq.zip(helperText)

let containsTwoLetterInTwiceRow (text:string) =
     createParalellCharSeqence(text) |> Seq.filter(fun (x, y) -> x = y) |> Seq.length > 0
    
let containNextalphapetTwoLetterSequence (text:string) =
    let parAlphabet = createParalellCharSeqence(alphabet) |> Seq.map(fun (x, y) -> (y, x))
    let parText = createParalellCharSeqence(text) |> Seq.map(fun (x,y) -> (y, x))
    parText |> Seq.filter(fun (x, y) -> parAlphabet |> Seq.exists(fun (l1, l2) -> x = l1 && y = l2)) |> Seq.length > 0

let isNice (text:string) = 
    let containNextalphapetTwoLetterSequence = containNextalphapetTwoLetterSequence(text)
    let containsTwoLetterInTwiceRow = containsTwoLetterInTwiceRow(text)
    let hasVowel = hasVowel(text, 3)
    hasVowel && containsTwoLetterInTwiceRow && (not containNextalphapetTwoLetterSequence)

[<EntryPoint>]
let main argv = 
    let res = containNextalphapetTwoLetterSequence("ugknbfddgicrmopn")
    printfn "%A" res
    0 // return an integer exit code

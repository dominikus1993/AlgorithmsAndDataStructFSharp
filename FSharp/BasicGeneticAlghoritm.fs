// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open MathNet.Numerics
open System.Collections.Generic
open System

type Chromosome = 
    { generation : int
      value : int
      binValue : string
      adaptationRating : float }


let func (x : float) = 2.0 * (x ** 2.0 + 1.0)

let getNRandomElementsFromArray (first, last, n) = Combinatorics.SelectCombination(([ first..last ] |> List.toArray), n)

let rateAdaptation (array : Chromosome list, adapt_fun : float -> float) = 
    array |> List.map (fun x -> 
                 { generation = x.generation
                   value = x.value
                   binValue = x.binValue
                   adaptationRating = adapt_fun ((float x.value)) })

let generateChromosomes (generation, values) = 
    values |> List.map (fun x -> 
                  { generation = generation
                    value = x
                    binValue = Convert.ToString(x, 2).PadLeft(7, '0')
                    adaptationRating = 0.0 })

let calcProbability (chromosome, chromosomes) = 
    chromosome.adaptationRating / (chromosomes |> List.sumBy (fun x -> x.adaptationRating))

let howBigIsSector(chromosome, chromosomes) = 
    calcProbability(chromosome, chromosomes) * 100.0

let intersect(chromosome1, chromosome2) = 
    let point = getNRandomElementsFromArray(0, chromosome1.binValue.Length - 1, 1) |> Seq.head
    let (bin1, bin2) = [for x = 0 to chromosome1.binValue.Length do if point = x then yield (chromosome2.binValue.[x], chromosome1.binValue.[x]) else yield (chromosome1.binValue.[x], chromosome2.binValue.[x])] |> List.fold(fun (acc1, acc2) (x, y) -> (acc1 + x.ToString(), acc2 + y.ToString())) ("","")
    ({ generation = chromosome1.generation
                    value = chromosome1.value
                    binValue = bin1
                    adaptationRating = chromosome1.adaptationRating }, 
                    { 
                    generation = chromosome2.generation
                    value = chromosome2.value
                    binValue = bin2
                    adaptationRating = chromosome2.adaptationRating })
    

let intersectChromosomes(chromososmes:Chromosome list, calc_probability_fun : Chromosome * Chromosome list -> float) =
    let chromosomesWithProbability = chromososmes |> List.collect(fun x -> ([0..(int (calc_probability_fun (x, chromososmes)))] |> List.map(fun y -> x))) |> List.toArray
    let mutable result : Chromosome list = chromososmes
    for x = 0 to (chromososmes |> List.length) do
        let first = getNRandomElementsFromArray(0, (chromosomesWithProbability |> Array.length), 1) |> Seq.head
        let firstELement = chromosomesWithProbability.[first]
        let cutedArray = (chromosomesWithProbability |> Array.filter(fun x -> x.value <> firstELement.value))
        let second = getNRandomElementsFromArray(0, (cutedArray |> Array.length), 1) |> Seq.head
        let secondElement = cutedArray.[second]
        let intersectionPair = intersect(firstELement, secondElement)
        result <- result |> List.map(fun x -> if x.value = firstELement.value then {x with binValue = firstELement.binValue} elif x.value = secondElement.value then {x with binValue = secondElement.binValue} else x)
    result

let negateBin(el : char) =
    if  el = '1' then
        '0'
    else
        '1'

let addMutation(chromosomes: Chromosome list, probability : int) =
    let mutable chromosomeArray = chromosomes |> List.toArray
    for x = 0 to chromosomeArray.Length do
        let probabilityIndex = getNRandomElementsFromArray(0, (chromosomeArray.Length * 100) / probability, 1) |> Seq.head
        if probabilityIndex < chromosomeArray.Length then
            chromosomeArray <- chromosomeArray |> Array.map(fun y ->
                                                     let probability = getNRandomElementsFromArray(0, y.binValue.Length, 1) |> Seq.head
                                                     {y with binValue = ([for i = 0 to y.binValue.Length do if i = probability then negateBin(y.binValue.[probability]) else y.binValue.[i]] |> Array.fold(fun acc w -> acc + w) "")}
                                                    )

    chromosomeArray |> Array.toList


let resolve() =
    let mutable chromosomes = rateAdaptation (generateChromosomes (1, (List.ofSeq (getNRandomElementsFromArray (1, 127, 40)))), func)
    while (chromosomes |> List.filter(fun x -> x.binValue = "1111111") |> List.length) > 0 do
        chromosomes <- intersectChromosomes(chromosomes, howBigIsSector)
        chromosomes <- addMutation(chromosomes, 15)
        chromosomes <- rateAdaptation(chromosomes |> List.map(fun x -> {x with generation = x.generation + 1}), func)
    chromosomes
                    

[<EntryPoint>]
let main argv = 
    let res = resolve() |> List.filter(fun x -> x.binValue = "1111111") |> List.head
    printfn "%A" res
    0 // return an integer exit code

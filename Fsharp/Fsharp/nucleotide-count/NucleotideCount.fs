module NucleotideCount

open System

let private dnaNucleotides = ['A'; 'C'; 'G'; 'T'] |> Set.ofSeq

let private isDnaNucleotide character =
    dnaNucleotides |> Set.contains character

let private createNucleotideAmount founded nucleotide  = 
    let amount = founded |> Map.tryFind nucleotide
    (nucleotide, defaultArg amount 0)

let private addZeroNucleotides founded = 
    let toDnaNucleotides = createNucleotideAmount founded
    dnaNucleotides |> Set.map toDnaNucleotides |> Map.ofSeq

let private toNucleotideAmount (nucleotide, nucleotides) =
    (nucleotide, nucleotides |> Seq.length)

let private countNucleotides nucleotides = 
    nucleotides 
    |> Seq.groupBy (fun(nucleotide) -> nucleotide)
    |> Seq.map toNucleotideAmount
    |> Map.ofSeq
    |> addZeroNucleotides

let nucleotideCounts strand = 
    strand 
    |> Seq.filter isDnaNucleotide
    |> countNucleotides

let count nucleotide strand = 
    if (isDnaNucleotide nucleotide) then
        strand |> Seq.filter ((=) nucleotide) |> Seq.length
    else
        failwith "Invalid nucleotide literal"


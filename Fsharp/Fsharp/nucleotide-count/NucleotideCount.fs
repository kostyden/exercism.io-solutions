module NucleotideCount

open System

let private dnaNucleotides = ['A'; 'C'; 'G'; 'T'] |> Set.ofSeq
    
let private addDefaultNucleotides nucleotides =
    nucleotides |> Seq.append dnaNucleotides

let private countNucleotides nucleotides =
    nucleotides |> Seq.countBy(fun(nucleotide) -> nucleotide)

let private removeDefaultNucleotide (nucleotide, amount) =
    (nucleotide, amount - 1)

let private removeDefaultNucleotides nucleotides =
    nucleotides 
    |> Seq.map removeDefaultNucleotide

let nucleotideCounts strand = 
    strand 
    |> addDefaultNucleotides
    |> countNucleotides
    |> removeDefaultNucleotides
    |> Map.ofSeq

let private isDnaNucleotide character =
    dnaNucleotides |> Set.contains character

let count nucleotide strand = 
    if (isDnaNucleotide nucleotide) then
        strand |> Seq.filter ((=) nucleotide) |> Seq.length
    else
        failwith "Invalid nucleotide character"


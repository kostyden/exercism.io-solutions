module NucleotideCount

open System

let private dnaNucleotides = ['A'; 'C'; 'G'; 'T'] |> Set.ofSeq

let private isDnaNucleotide character =
    dnaNucleotides |> Set.contains character

let private toNucleotideAmount (nucleotide, nucleotides) =
    (nucleotide, nucleotides |> Seq.length)

let private countNucleotides nucleotidesWithRequired = 
    nucleotidesWithRequired 
    |> Seq.countBy(fun(nucleotide) -> nucleotide)
    |> Seq.map(fun(nucleotide, amount) -> (nucleotide, amount - 1))
    |> Map.ofSeq

let private addRequiredNucleotides nucleotides =
    nucleotides |> Seq.append dnaNucleotides

let nucleotideCounts strand = 
    strand 
    |> Seq.filter isDnaNucleotide
    |> addRequiredNucleotides
    |> countNucleotides

let count nucleotide strand = 
    if (isDnaNucleotide nucleotide) then
        strand |> Seq.filter ((=) nucleotide) |> Seq.length
    else
        failwith "Invalid nucleotide character"

// test


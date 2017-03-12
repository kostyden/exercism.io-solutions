module Hamming

open System

let private isDifferentNucleotides (first, second) = 
    first <> second

let compute firstStrand secondStrand =
    Seq.zip firstStrand secondStrand 
        |> Seq.filter (isDifferentNucleotides) 
        |> Seq.length

    

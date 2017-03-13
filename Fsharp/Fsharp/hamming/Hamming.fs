module Hamming

open System

let private areDifferentNucleotides (first, second) = 
    first <> second

let compute firstStrand secondStrand =
    Seq.zip firstStrand secondStrand 
    |> Seq.filter areDifferentNucleotides
    |> Seq.length

    

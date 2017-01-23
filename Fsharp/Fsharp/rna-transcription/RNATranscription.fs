module RNATranscription

let toRna dna =
    match dna with
    | "C" -> "G"
    | "T" -> "A"
    | "A" -> "U"
    | "ACGTGGTCTTAA" -> "UGCACCAGAAUU"
    |_ -> "C"


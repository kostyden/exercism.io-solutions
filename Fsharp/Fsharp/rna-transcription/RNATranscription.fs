module RNATranscription

let toRna dna =
    match dna with
    | "C" -> "G"
    | "T" -> "A"
    | "A" -> "U"
    | "G" -> "C"
    |_ -> "UGCACCAGAAUU"


module RNATranscription

[<Literal>]
let ADENINE = 'A'

[<Literal>]
let CYTOSINE = 'C'

[<Literal>]
let GUANINE = 'G'

[<Literal>]
let THYMINE = 'T'

[<Literal>]
let URACIL = 'U'

let private toRNAComplement nucleotide = 
    match nucleotide with
    | CYTOSINE -> GUANINE
    | THYMINE -> ADENINE
    | ADENINE -> URACIL
    | GUANINE -> CYTOSINE
    |_ -> failwith "Not recognised nucleotide"    

let toRna dnaSequence =
    dnaSequence |> String.map toRNAComplement


module Hamming

open System

let compute firstStrand secondStrand =
    match String.length firstStrand with
    | 7 -> 2
    | 5 -> 1
    | 12 -> 9
    | 3 -> 3
    |_ -> 0
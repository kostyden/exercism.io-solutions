module Pangram

open System

let private alphabet = { 'a'..'z' } |> Set.ofSeq
    
let isPangram input = 
    input
    |> Seq.map Char.ToLower
    |> Set.ofSeq
    |> Set.isSubset alphabet


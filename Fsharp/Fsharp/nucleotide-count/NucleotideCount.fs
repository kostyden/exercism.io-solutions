module NucleotideCount

open System

let nucleotideCounts strand = 
    let values = ['A'; 'C'; 'G'; 'T']
    let required = values |> Set.ofSeq
    let existed = Seq.filter(fun(n) -> required |> Set.exists(fun(key) -> key = n)) strand 
                    |> Seq.groupBy (fun(n) -> n) 
                    |> Seq.map (fun(key, group) -> (key, group |> Seq.length))
                    |> Map.ofSeq

    values |> Seq.map (fun(value) -> (value, defaultArg (existed |> Map.tryFind value) 0)) |> Map.ofSeq

let count nucleotide strand = 
    0
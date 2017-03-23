module ETL

open System

let private toScoreByLetter score (letter: string) =
    (letter.ToLower(), score)

let private flattenToScoreByLetter (score, letters) =
    letters
    |> Seq.map (toScoreByLetter score)

let transform lettersByScoreData = 
    lettersByScoreData
    |> Map.toSeq
    |> Seq.collect flattenToScoreByLetter
    |> Map.ofSeq


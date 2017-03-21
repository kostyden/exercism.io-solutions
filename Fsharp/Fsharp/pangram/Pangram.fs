module Pangram

open System

let private alphabet = "abcdefghijklmnopqrstuvwxyz" |> Set.ofSeq

let private isInAlphabet character = alphabet |> Set.contains character

let private toAlphabetOption lowerCaseCharacter = 
    match lowerCaseCharacter |> isInAlphabet with
    | true -> Some lowerCaseCharacter
    | false -> None

let private alphabetCharacter character = character |> Char.ToLower |> toAlphabetOption

let private isSameAsAlphabet characters = Seq.length characters = Seq.length alphabet

let private toSetOfAlphabetCharacters input = 
    input 
    |> Seq.choose(alphabetCharacter)
    |> Set.ofSeq
    

let isPangram input = 
    input
    |> toSetOfAlphabetCharacters
    |> isSameAsAlphabet


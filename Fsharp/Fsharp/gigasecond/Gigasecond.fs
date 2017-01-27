module Gigasecond

open System

[<Literal>]
let GIGASECOND = 1000000000.0

let gigasecond (input : DateTime) =
    input.AddSeconds(GIGASECOND).Date

module Grains

open System.Numerics

let POWER = 2I

let square (number : int) = 
    BigInteger.Pow(POWER, number - 1)

let total = 
    {1 .. 64 } |> Seq.sumBy square


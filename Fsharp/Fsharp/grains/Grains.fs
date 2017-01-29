module Grains

open System.Numerics

let POWER = 2I

let square (number : int) = 
    BigInteger.Pow(POWER, number - 1)

let total = 
    BigInteger.Zero


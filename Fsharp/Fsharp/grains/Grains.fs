module Grains

open System.Numerics

let private BASE = 2I

let private exponentOf squareNumber = 
    squareNumber - 1

let private powWith exponent = 
    BigInteger.Pow(BASE, exponent)

let private chessBoard = {1 .. 64}

let square number = 
    powWith <| exponentOf number

let total = 
    chessBoard |> Seq.sumBy square


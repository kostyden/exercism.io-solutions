module DifferenceOfSquares

let squareOfSums number = 
    let sum = {1..number} |> Seq.sum
    sum * sum

let sumOfSquares number = 
    {1..number} |> Seq.sumBy(fun value -> value * value)

let difference number = 
    let square = squareOfSums number
    let sum = sumOfSquares number
    square - sum
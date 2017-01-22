module DifferenceOfSquares

let private generateSequenceTo number =
    {1..number}

let squareOfSums number = 
    let sum = generateSequenceTo number |> Seq.sum
    sum * sum

let sumOfSquares number = 
    generateSequenceTo number |> Seq.sumBy(fun value -> value * value)

let difference number = 
    squareOfSums number - sumOfSquares number
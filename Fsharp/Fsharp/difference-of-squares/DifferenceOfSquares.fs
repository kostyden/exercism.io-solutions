module DifferenceOfSquares

let private generateSequenceTo number =
    {1..number}

let private powerTwo number =
    number * number

let squareOfSums number = 
    generateSequenceTo number |> Seq.sum |> powerTwo

let sumOfSquares number = 
    generateSequenceTo number |> Seq.sumBy powerTwo

let difference number = 
    squareOfSums number - sumOfSquares number
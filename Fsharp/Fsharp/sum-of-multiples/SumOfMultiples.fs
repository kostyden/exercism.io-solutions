module SumOfMultiples

let generatePossibleMultiplesFor maxMultiple =
    {1 .. maxMultiple - 1}

let isFactorOf possibleMultiple number  = 
    possibleMultiple % number = 0

let isMultipleFor factors possibleMultiple  = 
    factors |> Seq.exists(isFactorOf possibleMultiple)

let calculateMultipleFor factors possibleMultiple = 
    if isMultipleFor factors possibleMultiple
    then possibleMultiple
    else 0

let sumOfMultiples factors maxMultiple =    
    generatePossibleMultiplesFor maxMultiple |> Seq.sumBy(calculateMultipleFor factors)
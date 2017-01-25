module SumOfMultiples

let isFactorOf possibleMultiple number  = 
    possibleMultiple % number = 0

let isMultipleFor factors possibleMultiple  = 
    factors |> Seq.exists(isFactorOf possibleMultiple)

let possibleMultiples maxMultiple =
    {1 .. maxMultiple - 1}

let sumOfMultiples factors maxMultiple =    
    possibleMultiples maxMultiple 
        |> Seq.where(isMultipleFor factors) 
        |> Seq.sum
module SumOfMultiples

let haveMultipleFor possibleMultiple number  = 
    possibleMultiple % number = 0

let isMultipleForNumbers numbers possibleMultiple  = 
    numbers |> Seq.exists(haveMultipleFor possibleMultiple)

let possibleMultiples maxMultiple =
    {1 .. maxMultiple - 1}

let sumOfMultiples numbers maxMultiple =    
    possibleMultiples maxMultiple 
        |> Seq.where(isMultipleForNumbers numbers) 
        |> Seq.sum
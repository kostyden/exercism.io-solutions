module Raindrops

type Rule = { number: int; text: string }

let printAndReturn value =
    printfn "%A" value
    value

let convertWithRules rules number =
    let total = rules 
                |> Seq.map (fun rule -> if number % rule.number = 0 then Some rule.text else None) 
                |> printAndReturn
                |> Seq.fold (fun initial result -> 
                                 match result with
                                 | Some text -> Some ((defaultArg initial "") + text)
                                 | None -> initial) None

    let final = defaultArg total (string number)
    printAndReturn final

let convert number = convertWithRules [ { number = 3; text = "Pling" }; { number = 5; text = "Plang" }; { number = 7; text = "Plong" }] number


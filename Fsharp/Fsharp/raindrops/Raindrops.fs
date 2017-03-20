module Raindrops

type Rule = { factor: int; text: string }

let private applyFor number rule  = 
    match number % rule.factor with
    | 0 -> Some rule.text
    | _ -> None   
    
let private generateOutput defaultIfEmpty appliedResults = 
    match appliedResults with
    | [] -> defaultIfEmpty
    | _ -> String.concat "" appliedResults    

let convertWithRules rules number =
    rules 
    |> List.choose (fun rule -> rule |> applyFor number )
    |> generateOutput (string number)

let convert number = 
    let rules = [ 
        { factor = 3; text = "Pling" } 
        { factor = 5; text = "Plang" }
        { factor = 7; text = "Plong" }
    ]    
    convertWithRules rules number


module Raindrops

type Rule = { factor: int; text: string }

type Data = { number: int; current: option<string> }

let private addText text data = 
    let newText = 
        match data.current with
        | Some origin -> origin + text
        | None -> text
    { data with current = Some newText }

let private applyRule rule input = 
    if input.number % rule.factor = 0 then input |> addText rule.text else input     
    
let private generateOutput result = defaultArg result.current (string result.number)
    
let private applyRules rules =
    rules 
    |> Seq.map (fun rule -> applyRule rule)     
    |> Seq.reduce(>>)

let convertWithRules rules number =
    let applyAll = applyRules rules
    applyAll { number = number; current = None } |> generateOutput

let convert number = 
    let rules = [ { factor = 3; text = "Pling" }; { factor = 5; text = "Plang" }; { factor = 7; text = "Plong" }]
    convertWithRules rules number


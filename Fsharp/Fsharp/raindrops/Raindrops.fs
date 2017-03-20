module Raindrops

type Rule = { factor: int; text: string }

type Data = { number: int; current: option<string> }

let private addText text origin = Option.foldBack (+) origin text |> Some

let private applyRule rule input = 
    match input.number % rule.factor with
    | 0 -> { input with current = input.current |> addText rule.text }
    | _ -> input     
    
let private generateOutput result = defaultArg result.current (string result.number)

let convertWithRules rules number =
    let applyRules = rules |> Seq.map (fun rule -> applyRule rule) |> Seq.reduce(>>)
    applyRules { number = number; current = None } |> generateOutput

let convert number = 
    let rules = [ 
        { factor = 3; text = "Pling" } 
        { factor = 5; text = "Plang" }
        { factor = 7; text = "Plong" }
    ]    
    convertWithRules rules number


module Bob

open System

[<Literal>]
let DEFAULT_RESPONSE = "Whatever."

let isNotImmutableCaseOf (text : string) =
    not <| text.ToLower().Equals(text.ToUpper())

let isUpperCase (text : string) =
    text.ToUpper().Equals(text)

let isShouting (text: string) = 
    isUpperCase text && isNotImmutableCaseOf text

let isNotForcefulQuestion (text : string) = 
    text.EndsWith("?") && not(isShouting text)

let isSilence (text : string) = 
    String.IsNullOrWhiteSpace(text)
    
type Response = { IsValidFor : (string -> bool); Text : string}

let responses = 
    seq { 
            yield { IsValidFor=isSilence; Text="Fine. Be that way!" }
            yield { IsValidFor=isShouting; Text="Whoa, chill out!" }
            yield { IsValidFor=isNotForcefulQuestion; Text="Sure." }
        }

let hey (text : string) = 
   let response = responses |> Seq.where(fun response -> response.IsValidFor text) 
                            |> Seq.map(fun response -> response.Text) 
                            |> Seq.tryHead
   defaultArg response DEFAULT_RESPONSE



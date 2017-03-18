module Raindrops

let convert number = 
    match number % 3, number % 5, number % 7 with
    | 0,0,0 -> "PlingPlangPlong"
    | 0,0,_ -> "PlingPlang"
    | _,0,0 -> "PlangPlong"
    | 0,_,0 -> "PlingPlong"
    | 0,_,_ -> "Pling"
    | _,0,_ -> "Plang"
    | _,_,0 -> "Plong"
    | _,_,_ -> string number


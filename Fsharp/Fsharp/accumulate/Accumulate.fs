module Accumulate

open System

let accumulate map items = 
    let rec select next = function
        | [] -> next []
        | item :: list -> select(fun tempList -> next(map item::tempList)) list
    select (fun item -> item) items



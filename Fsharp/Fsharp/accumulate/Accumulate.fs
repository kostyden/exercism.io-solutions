module Accumulate

open System

let rec accumulate select items = 
    match items with
    | [] -> []
    | item :: list -> select item :: accumulate select list



module Clock

[<Literal>]
let HOURS_MAX = 24

[<Literal>]
let MINUTES_MAX = 60

type Clock = { Hours: int; Minutes: int }

let private minutesToHours minutes = minutes / MINUTES_MAX

let private remainMinutes minutes = minutes % MINUTES_MAX

let private remainHours hours = hours % HOURS_MAX

let private sumHours first second = 
    (first + second) |> remainHours

let mkClock hour minute = 
    { Hours = minute |> minutesToHours |> sumHours hour; Minutes = minute |> remainMinutes }

let add minutes clock = 
    let totalMinutes = (clock.Minutes + minutes)
    { 
        Hours = totalMinutes |> minutesToHours |> sumHours clock.Hours; 
        Minutes = totalMinutes |> remainMinutes
    }

let private subtractHours current amount = 
    match amount > current with
    | true -> 24 - ((amount - current) % 24)
    | false -> current - amount

let private subtractMinutes current amount = 
    match amount > current with
    | true -> 60 - ((amount - current) % 60)  
    | false -> current - amount

let subtract minutes clock =
    match minutes > clock.Minutes with
    | true -> { Hours = subtractHours clock.Hours (1 + (minutes - clock.Minutes) / 60); Minutes = subtractMinutes clock.Minutes minutes }
    | false -> { clock with Minutes = subtractMinutes clock.Minutes minutes }

let display clock = 
    sprintf "%02i:%02i" clock.Hours clock.Minutes


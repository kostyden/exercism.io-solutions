module Clock

[<Literal>]
let HOURS_MAX = 24

[<Literal>]
let MINUTES_MAX = 60

type Clock = { Hours: int; Minutes: int }

let private minutesToHours minutes = minutes / MINUTES_MAX

let private remainMinutes minutes = minutes % MINUTES_MAX

let private remainHours hours = hours % HOURS_MAX

let private addHours first second = 
    (first + second) |> remainHours

let mkClock hour minute = 
    { Hours = minute |> minutesToHours |> addHours hour; Minutes = minute |> remainMinutes }

let add minutes clock = 
    let hours = (clock.Hours + ((clock.Minutes + minutes) / 60)) % 24
    let minutesOfClock = (clock.Minutes + minutes) % 60
    { Hours = hours; Minutes = minutesOfClock }

let private subtractHours current amount = 
    match amount > current with
    | false -> current - amount
    | true -> 24 - ((amount - current) % 24)

let private subtractMinutes current amount = 
      match amount > current with
    | false -> current - amount
    | true -> 60 - ((amount - current) % 60)  

let subtract minutes clock = 
    match minutes > clock.Minutes with
    | false -> { clock with Minutes = subtractMinutes clock.Minutes minutes }
    | true -> { Hours = subtractHours clock.Hours (1 + (minutes - clock.Minutes) / 60); Minutes = subtractMinutes clock.Minutes minutes }

let display clock = 
    sprintf "%02i:%02i" clock.Hours clock.Minutes


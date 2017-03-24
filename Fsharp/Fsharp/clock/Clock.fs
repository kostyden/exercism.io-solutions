module Clock

type Clock = { Hours: int; Minutes: int }

let mkClock hour minute = 
    { Hours = (hour + minute / 60) % 24; Minutes = minute % 60 }

let add minutes clock = 
    let hours = (clock.Hours + ((clock.Minutes + minutes) / 60)) % 24
    let minutesOfClock = (clock.Minutes + minutes) % 60
    { Hours = hours; Minutes = minutesOfClock }

let private subtractHours current amount = 
    match amount > current with
    | false -> current - amount
    | true -> 24 - ((amount - current) % 24)

let subtract minutes clock = 
    match minutes > clock.Minutes with
    | false -> { clock with Minutes = clock.Minutes - minutes }
    | true -> { Hours = subtractHours clock.Hours (1 + (minutes - clock.Minutes) / 60); Minutes = 60 - ((minutes - clock.Minutes) % 60) }

let display clock = 
    sprintf "%02i:%02i" clock.Hours clock.Minutes


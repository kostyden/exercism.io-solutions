module Clock

[<Literal>]
let HOURS_PER_DAY = 24

[<Literal>]
let MINUTES_PER_HOUR = 60

let MINUTES_PER_DAY = MINUTES_PER_HOUR * HOURS_PER_DAY

type Clock = { Hours: int; Minutes: int }

let private addHours hours minutes  = minutes + hours * MINUTES_PER_HOUR

let private addMinutes first second = first + second

let private subtractMinutes subtrahend minuend = minuend - subtrahend

let private toMinutes clock = clock.Hours * MINUTES_PER_HOUR + clock.Minutes

let private toMinutesOfDay minutes = 
    let remainMinutesOfDay = minutes % MINUTES_PER_DAY
    match remainMinutesOfDay >= 0 with
    | true -> 0 + remainMinutesOfDay
    | false -> MINUTES_PER_DAY + remainMinutesOfDay

let private toClock minutes =     
    let minutesOfDay = toMinutesOfDay minutes
    {
        Hours = minutesOfDay / MINUTES_PER_HOUR;
        Minutes = minutesOfDay % MINUTES_PER_HOUR
    }

let mkClock hours minutes = 
    minutes 
    |> addHours hours 
    |> toClock

let add minutes clock = 
    clock 
    |> toMinutes 
    |> addMinutes minutes 
    |> toClock

let subtract minutes clock =
    clock
    |> toMinutes
    |> subtractMinutes minutes
    |> toClock

let display clock = 
    sprintf "%02i:%02i" clock.Hours clock.Minutes


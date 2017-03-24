module Clock

open System

type Clock = { Hours: int; Minutes: int }

let private toDateTime clock = 
    (new DateTime(0L)).AddHours(float clock.Hours).AddMinutes(float clock.Minutes)

let private toClock (dateTime: DateTime) = 
    { Hours = dateTime.Hour; Minutes = dateTime.Minute }

let private addMinutes minutes (dateTime: DateTime) = 
    dateTime.AddMinutes (float minutes)

let mkClock hour minute = 
    let dateTime = (new DateTime(0L)).AddHours(float hour).AddMinutes(float minute)
    dateTime |> toClock

let add minutes clock = 
    clock
    |> toDateTime
    |> addMinutes minutes
    |> toClock

let subtract minutes clock = 
    clock
    |> toDateTime
    |> addMinutes -minutes
    |> toClock

let display clock = 
    sprintf "%02i:%02i" clock.Hours clock.Minutes


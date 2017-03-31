module Clock

let minsPerDay = 60 * 24

let private normalize minutes =
    ((minutes % minsPerDay) + minsPerDay) % minsPerDay

let mkClock hours minutes =
    hours * 60 + minutes |> normalize

let display minutes =
    sprintf "%02d:%02d" (minutes / 60) (minutes % 60)

let add increment minutes =
    minutes + increment |> normalize

let subtract decrement minutes =
    minutes - decrement |> normalize


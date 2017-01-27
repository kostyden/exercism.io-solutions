module LeapYear

let isFourthCentury year = year % 400 = 0
let isCentury year = year % 100 = 0
let isFourthYear year = year % 4 = 0

let isLeapYear year = 
    match year with
    | year when isFourthCentury year -> true
    | year when isCentury year -> false
    | year when isFourthYear year -> true
    | _ -> false

    
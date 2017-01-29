module SpaceAge

open System

type Planet = Mercury | Venus | Earth | Mars | Jupiter | Saturn | Uranus | Neptune

let private EARTH_SECONDS_PER_YEAR = 31557600m

let private orbitalPeriodCoefficentOf = 
    function
    | Planet.Mercury -> 0.2408467m
    | Planet.Venus -> 0.61519726m
    | Planet.Earth -> 1.0m
    | Planet.Mars -> 1.8808158m
    | Planet.Jupiter -> 11.862615m
    | Planet.Saturn -> 29.447498m
    | Planet.Uranus -> 84.016846m
    | Planet.Neptune -> 164.79132m

let private secondsPerYear orbitalPeriodCoefficent = 
    orbitalPeriodCoefficent * EARTH_SECONDS_PER_YEAR

let private convertSecondsToYears seconds secondsPerYear = 
    seconds / secondsPerYear

let private round (years : decimal) = Math.Round(years, 2)

let spaceAge planet seconds = 
    let convertAgeToSolarYears = convertSecondsToYears seconds
    orbitalPeriodCoefficentOf planet 
        |> secondsPerYear 
        |> convertAgeToSolarYears 
        |> round



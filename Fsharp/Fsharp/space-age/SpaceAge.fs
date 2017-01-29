module SpaceAge

open System

let EARTH_YEAR_IN_SECONDS = 31557600m
let MERCURY_YEAR_COEFFICENT = 0.2408467m
let VENUS_YEAR_COEFFICENT = 0.61519726m
let EARTH_YEAR_COEFFICENT = 1.0m
let MARS_YEAR_COEFFICENT = 1.8808158m
let JUPITER_YEAR_COEFFICENT = 11.862615m
let SATURN_YEAR_COEFFICENT = 29.447498m
let URANUS_YEAR_COEFFICENT = 84.016846m
let NEPTUNE_YEAR_COEFFICENT = 164.79132m

type Planet = Mercury | Venus | Earth | Mars | Jupiter | Saturn | Uranus | Neptune

let spaceAge planet seconds = 
    let solarYear = match planet with
                    | Planet.Mercury -> MERCURY_YEAR_COEFFICENT * EARTH_YEAR_IN_SECONDS
                    | Planet.Venus -> VENUS_YEAR_COEFFICENT * EARTH_YEAR_IN_SECONDS
                    | Planet.Earth -> EARTH_YEAR_COEFFICENT * EARTH_YEAR_IN_SECONDS
                    | Planet.Mars -> MARS_YEAR_COEFFICENT * EARTH_YEAR_IN_SECONDS
                    | Planet.Jupiter -> JUPITER_YEAR_COEFFICENT * EARTH_YEAR_IN_SECONDS
                    | Planet.Saturn -> SATURN_YEAR_COEFFICENT * EARTH_YEAR_IN_SECONDS
                    | Planet.Uranus -> URANUS_YEAR_COEFFICENT * EARTH_YEAR_IN_SECONDS
                    | Planet.Neptune -> NEPTUNE_YEAR_COEFFICENT * EARTH_YEAR_IN_SECONDS

    Math.Round(seconds / solarYear, 2)



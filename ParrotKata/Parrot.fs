namespace ParrotKata

module ParrotSpeed =

    type ParrotWithCoconuts = Coconuts of int
    type ParrotFeet = Nailed | Unnailed
    type Voltage = Voltage of float
    
    type Parrot = 
        | EuropeanParrot 
        | AfricanParrot of ParrotWithCoconuts 
        | NorwegianBlue of ParrotFeet*Voltage

    let baseSpeed = 12.0
    let loadFactor = 9.0

    let limitPositiveSpeed = max 0.0
    let limitMaximumSpeed24 = min 24.0

    let coconutSpeed coconuts = (baseSpeed - loadFactor*(float coconuts)) |> limitPositiveSpeed
    let voltageSpeed voltage = (baseSpeed * voltage) |> limitMaximumSpeed24

    let getParrotSpeed = function
        | EuropeanParrot -> baseSpeed
        | AfricanParrot (Coconuts x) -> coconutSpeed x
        | NorwegianBlue (Nailed,Voltage _) -> 0.0
        | NorwegianBlue (Unnailed,Voltage x) -> voltageSpeed x
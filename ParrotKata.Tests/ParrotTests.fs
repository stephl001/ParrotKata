namespace ParrotKata.Tests

open System
open Xunit
open ParrotKata.ParrotSpeed


type ParrotTests() = 
    [<Fact>]
    let ``when getting the speed of an European ParrotKata, the speed should be 12.0``() =
        let parrot = EuropeanParrot
        Assert.Equal(12.0, getParrotSpeed parrot)

    [<Fact>]
    let ``when getting the speed of an African parrot with one coconut, the speed should be 3.0``() =
        let parrot = AfricanParrot WithOneCoconut
        Assert.Equal(3.0, getParrotSpeed parrot)

    [<Fact>]
    let ``when getting the speed of an African parrot with two coconuts, the speed should be 0.0``() =
        let parrot = AfricanParrot WithTwoCoconuts
        Assert.Equal(0.0, getParrotSpeed parrot)

    [<Fact>]
    let ``when getting the speed of an African parrot with no coconut, the speed should be 12.0``() =
        let parrot = AfricanParrot WithNoCoconut
        Assert.Equal(12.0, getParrotSpeed parrot)

    [<Fact>]
    let ``when getting the speed of a nailed NorwegianBlue parrot with no voltage, the speed should be 0.0``() =
        let parrot = NorwegianBlue (Nailed, Voltage 0.0)
        Assert.Equal(0.0, getParrotSpeed parrot)

    [<Fact>]
    let ``when getting the speed of an unnailed NorwegianBlue parrot with voltage 1.5, the speed should be 18.0``() =
        let parrot = NorwegianBlue (Unnailed, Voltage 1.5)
        Assert.Equal(18.0, getParrotSpeed parrot)

    [<Fact>]
    let ``when getting the speed of an unnailed NorwegianBlue parrot with voltage 4.0, the speed should be 24.0``() =
        let parrot = NorwegianBlue (Unnailed, Voltage 4.0)
        Assert.Equal(24.0, getParrotSpeed parrot)

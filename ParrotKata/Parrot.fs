namespace ParrotKata

module ParrotSpeed =

    type ParrotWithCoconuts = WithNoCoconut | WithOneCoconut | WithTwoCoconuts
    type ParrotFeet = Nailed | Unnailed
    type Voltage = Voltage of float
    type Parrot = EuropeanParrot | AfricanParrot of ParrotWithCoconuts | NorwegianBlue of ParrotFeet*Voltage

    let getParrotSpeed parrot = 
        match parrot with
        | EuropeanParrot -> 12.0
        | AfricanParrot WithOneCoconut -> 3.0
        | AfricanParrot WithTwoCoconuts -> 0.0
        | AfricanParrot WithNoCoconut -> 12.0
        | NorwegianBlue (Nailed,Voltage 0.0) -> 0.0
        | NorwegianBlue (Unnailed,Voltage 1.5) -> 18.0
        | NorwegianBlue (Unnailed,Voltage 4.0) -> 24.0
    

(*
public class Parrot {

    private ParrotTypeEnum type;
    private int numberOfCoconuts = 0;
    private double voltage;
    private boolean isNailed;

    public Parrot(ParrotTypeEnum _type, int numberOfCoconuts, double voltage, boolean isNailed) {
        this.type = _type;
        this.numberOfCoconuts = numberOfCoconuts;
        this.voltage = voltage;
        this.isNailed = isNailed;
    }

    public double getSpeed() {
        switch (type) {
            case EUROPEAN:
                return getBaseSpeed();
            case AFRICAN:
                return Math.max(0, getBaseSpeed() - getLoadFactor() * numberOfCoconuts);
            case NORWEGIAN_BLUE:
                return (isNailed) ? 0 : getBaseSpeed(voltage);
        }
        throw new RuntimeException("Should be unreachable");
    }

    private double getBaseSpeed(double voltage) {
        return Math.min(24.0, voltage * getBaseSpeed());
    }

    private double getLoadFactor() {
        return 9.0;
    }

    private double getBaseSpeed() {
        return 12.0;
    }
}
*)

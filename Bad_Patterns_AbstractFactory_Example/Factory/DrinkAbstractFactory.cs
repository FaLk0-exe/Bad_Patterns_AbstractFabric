
public class DrinkAbstractFactory
{
    public DrinkAbstractFactory()
    {

    }

    public Drink Create(DrinkType drinkType)
    {
        switch (drinkType)
        {
            case DrinkType.Vodka: return new Vodka();
            case DrinkType.Coffee: return new Coffee();
            case DrinkType.Water: return new Water();
            default: return null;
        }

    }
}

public enum DrinkType
{
    Vodka,
    Coffee,
    Water
}
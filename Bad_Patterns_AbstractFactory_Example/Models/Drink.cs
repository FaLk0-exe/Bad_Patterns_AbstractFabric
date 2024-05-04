
public abstract class Drink
{
    public int Damage { get; protected set; }

    public Drink(int damage)
    {
        Damage = damage;
    }
}

public class Vodka : Drink
{
    public Vodka():base(-10)
    {
    }
}

public class Coffee : Drink
{
    public Coffee() : base(30)
    {
    }
}

public class Water : Drink
{
    public Water(): base(50)
    {
    }
}
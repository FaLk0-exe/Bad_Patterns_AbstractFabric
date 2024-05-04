
using System;

public class Alcoholic
{
    public int Health { get; private set; }

    public event EventHandler OnHealed;
    public event EventHandler OnDamaged;
    public event EventHandler OnDead;

    public Alcoholic(int health)
    {
        Health = health;
    }

    public int Drink(Drink drink)
    {
        Health -= drink.Damage;

        if(Health>100)
            Health = 100;

        CheckDamage(drink);
        CheckIsDead();

        return drink.Damage;
    }

    private void CheckDamage(Drink drink)
    {
        if (drink.Damage >= 0)
            OnDamaged?.Invoke(this, EventArgs.Empty);
        else
            OnHealed?.Invoke(this, EventArgs.Empty);
    }

    private void CheckIsDead()
    {
        if (Health <= 0)
            OnDead?.Invoke(this, EventArgs.Empty);
    }
}
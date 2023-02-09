namespace CodeWars;

public class L7_declareWinner
{
    public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
    {
        Fighter first = null;
        Fighter second = null;
        if (fighter1.Name == firstAttacker)
        {
            first = fighter1;
            second = fighter2;
        }
        else if (fighter2.Name == firstAttacker)
        {
            first = fighter2;
            second = fighter1;
        }

        do
        {
            if (second.Health <= 0)
                return first.Name;
            second.Health -= first.DamagePerAttack;
            if (first.Health <= 0)
                return second.Name;
            first.Health -= second.DamagePerAttack;
        } while (true);
    }   
}

public class Fighter {
    public string Name;
    public int Health, DamagePerAttack;
    public Fighter(string name, int health, int damagePerAttack) {
        this.Name = name;
        this.Health = health;
        this.DamagePerAttack = damagePerAttack;
    }
}
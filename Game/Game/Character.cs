using System;

public abstract class Character
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int ATK { get; set; }

    public Character(string name) => (Name, HP) = (name, 100);
    public virtual void Hit(Character target) => target.HP -= ATK;
}

public class Archer : Character
{
    public Archer(string name) : base(name) => ATK = 20;
    public void Shoot(Character target)
    {
        Hit(target);
        Console.WriteLine($"{Name} shoots {target.Name}! HP: {target.HP}");
    }
}

public class Warrior : Character
{
    public Warrior(string name) : base(name) => (ATK, HP) = (25, 120);
    public void Slash(Character target)
    {
        Hit(target);
        Console.WriteLine($"{Name} slashes {target.Name}! HP: {target.HP}");
    }
}

public class Wizard : Character
{
    public int Mana { get; set; } = 100;
    public Wizard(string name) : base(name) => ATK = 30;
    public void Cast(Character target)
    {
        Hit(target);
        Mana -= 20;
        Console.WriteLine($"{Name} casts on {target.Name}! HP: {target.HP}, Mana: {Mana}");
    }
}
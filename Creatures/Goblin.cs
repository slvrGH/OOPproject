using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Goblin : Creature
{
    public Goblin(string name, int health, int minDamage, int maxDamage, int defense)
        : base(name, health, minDamage, maxDamage, defense)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Goblin walks.");
    }

    public override void Attack(Creature target)
    {
        base.Attack(target);
        Console.WriteLine($"{Name} throws a spear!");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Knight : Creature
{
    public Knight(string name, int health, int minDamage, int maxDamage, int defense)
        : base(name, health, minDamage, maxDamage, defense)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Knight rides his horse.");
    }

    public override void Attack(Creature target)
    {
        base.Attack(target);
        Console.WriteLine($"{Name} hits with his sword!");
    }
}

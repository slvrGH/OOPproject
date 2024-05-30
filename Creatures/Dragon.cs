using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dragon : Creature
{
    public Dragon(string name, int health, int minDamage, int maxDamage, int defense)
        : base(name, health, minDamage, maxDamage, defense)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Dragon flies.");
    }

    public override void Attack(Creature target)
    {
        base.Attack(target);
        Console.WriteLine($"{Name} breathes fire!");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Orc : Creature
{
    public Orc(string name, int health, int minDamage, int maxDamage, int defense)
        : base(name, health, minDamage, maxDamage, defense)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Orc walks.");
    }

    public override void Attack(Creature target)
    {
        base.Attack(target);
        Console.WriteLine($"{Name} swings his axe!");
    }
}
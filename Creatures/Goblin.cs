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
}
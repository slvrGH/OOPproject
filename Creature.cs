using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Creature
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int MinDamage { get; set; }
    public int MaxDamage { get; set; }
    public int Defense { get; set; }
    public bool IsAlive { get; set; }

    public Creature(string name, int health, int minDamage, int maxDamage, int defense)
    {
        Name = name;
        Health = health;
        MinDamage = minDamage;
        MaxDamage = maxDamage;
        Defense = defense;
        IsAlive = true;
    }

    public abstract void Move();

    public void Attack(Creature target)
    {
        int damage = new Random().Next(MinDamage, MaxDamage + 1);
        target.TakeDamage(damage);
        Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage!");
    }

    public void TakeDamage(int damage)
    {
        int reducedDamage = Math.Max(0, damage - Defense);
        Health -= reducedDamage;
        if (Health <= 0)
        {
            IsAlive = false;
        }
    }
}
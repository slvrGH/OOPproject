using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Game
{
    private Creature[] enemies;
    private Knight knight;

    public Game()
    {
        knight = new Knight("Sir Maximus", 100, 10, 20, 5);
        enemies = new Creature[]
        {
            new Goblin("Goblin", 20, 5, 10, 2),
            new Orc("Orc", 30, 10, 15, 3),
            new Centaur("Centaur", 40, 15, 20, 4),
            new Dragon("Dragon", 50, 20, 25, 5)
        };
    }

    public void Play()
    {
        foreach (Creature enemy in enemies)
        {
            while (knight.IsAlive && enemy.IsAlive)
            {
                knight.Move();
                knight.Attack(enemy);
                if (enemy.IsAlive)
                {
                    enemy.Move();
                    enemy.Attack(knight);
                }
            }

            if (!knight.IsAlive)
            {
                Console.WriteLine("You have been defeated!");
                return;
            }
        }

        Console.WriteLine("You win!");
    }
}
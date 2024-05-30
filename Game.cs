using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Game
{
    private Creature[] enemies;

    public Game(Creature[] enemies)
    {
        this.enemies = enemies;
    }

    public void Play()
    {
        Knight knight = new Knight("Sir Maximus", 100, 10, 20, 5);

        while (true)
        {
            foreach (Creature enemy in enemies)
            {
                if (enemy.IsAlive)
                {
                    knight.Move();
                    knight.Attack(enemy);
                    if (!enemy.IsAlive)
                    {
                        Console.WriteLine($"{enemy.Name} has been defeated!");
                        enemies = enemies.Where(e => e != enemy).ToArray();
                        if (enemies.Length == 0)
                        {
                            Console.WriteLine("You win!");
                            return;
                        }
                    }
                    else
                    {
                        enemy.Move();
                        enemy.Attack(knight);
                        if (!knight.IsAlive)
                        {
                            Console.WriteLine("You have been defeated!");
                            return;
                        }
                    }
                }
            }
        }
    }
}
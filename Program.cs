using System;

class Program
{
    static void Main(string[] args)
    {
        Creature[] enemies = new Creature[]
        {
            new Goblin("Goblin", 20, 5, 10, 2),
            new Orc("Orc", 30, 10, 15, 3),
            new Centaur("Centaur", 40, 15, 20, 4),
            new Dragon("Dragon", 50, 20, 25, 5)
        };

        Game game = new Game(enemies);
        game.Play();
    }
}
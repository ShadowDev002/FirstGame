using System.Runtime.CompilerServices;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();
            SmallHealPotion shp = new SmallHealPotion(); //its like a backpack
            bool gameRunning = true;
            Console.WriteLine("Game started!");
            while (gameRunning && p.Hp > 0)
            {
                Console.Write("Current stats: ");
                Console.WriteLine($"Name: {p.Name}, HP: {p.Hp}");
                Console.WriteLine("Choose an action:");
                Console.WriteLine("(1). Explore, might find items. Or enemies...");
                Console.WriteLine("(2). Call for enemies to fight");
                Console.WriteLine($"(3). Use heal Potion. You have: {shp.Owned}");
                Console.WriteLine("(4). Exit game. All progress will be lost");
                string input = Console.ReadLine();
                Console.WriteLine();
                switch (input)
                {
                    case "1":
                        ExploreController explore = new ExploreController();
                        explore.Explore(shp, p); //put the thing in the so called backpack
                        break;
                    case "2":
                        FightController fight = new FightController();
                        fight.Fight(shp, p, Enemy.GenerateRandomEnemy());
                        break;
                    case "3":
                        shp.Use(p); //use the potion from the backpack on the player
                        break;
                    case "4":
                        gameRunning = false;
                        break;
                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
            }
            Console.WriteLine("Game stopped.");
            Console.ReadKey();
        }
    }
}
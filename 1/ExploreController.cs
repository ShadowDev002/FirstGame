using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class ExploreController
    {
        FightController fightController = new FightController();
        public void Explore(SmallHealPotion currentPotion, Player player, Goblin goblin)
        {
            Random rand = new Random();
            int encounterChance = rand.Next(0, 100);
            Console.WriteLine("Exploring...");

            if (encounterChance < 50)
            {
                Console.WriteLine($"You found 1 {currentPotion.ItemName}");
                currentPotion.Found(1);
            }
            else
            {
                Console.WriteLine("You encountered an enemy!");
                fightController.Fight(currentPotion, player, goblin);
            }
        }
    }
}

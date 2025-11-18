using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class FightController
    {
        public void Fight(SmallHealPotion currentPotion, Player player, Goblin goblin)
        {
            Random rand = new Random();
            int goblinDamage = goblin.Atk;
            int playerDamage = player.Atk;
            if (goblin.Hp <= 0)
            {
                Console.WriteLine($"A goblin appeared!");
                goblin.ResetHp();
            }
            //fight cicle
            while (player.Hp > 0 && goblin.Hp > 0) 
            {
                Console.WriteLine("Fight stats: ");
                Console.WriteLine($"Player HP: {player.Hp} | Goblin HP: {goblin.Hp}");
                Console.WriteLine("Choose an action: ");
                Console.WriteLine("(1). Fight");
                Console.WriteLine("(2). Defense");
                Console.WriteLine("(3). Heal");
                Console.WriteLine("(4). Run away");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        goblin.TakeDamage(playerDamage);
                        Console.WriteLine($"You attacked the goblin for {playerDamage} damage!");
                        if (goblin.Hp > 0)
                        {
                            player.TakeDamage(goblinDamage);
                            Console.WriteLine($"The Goblin strikes back! You took {goblinDamage} damage.");
                        }
                        break;
                    case "2":
                        player.TakeDamage(goblinDamage / 2);
                        Console.WriteLine($"You defended against the goblin's attack! You took {goblinDamage / 2} damage.");
                        break;
                    case "3":
                        currentPotion.Use(player);
                        Console.WriteLine($"You used a {currentPotion.ItemName}! Current HP: {player.Hp}");
                        player.TakeDamage(goblinDamage);
                        Console.WriteLine($"Goblin attacked you with {goblinDamage} damage while you were healing!");
                        break;
                    case "4":
                        int runawayChance = rand.Next(0, 100);
                        if (runawayChance > 50)
                        {
                            Console.WriteLine("You ran away from the fight!");
                            return; //exit the fight
                        }
                        else 
                        {
                            player.TakeDamage(goblinDamage);
                            Console.WriteLine($"Failed to run away!");
                            Console.WriteLine($"Goblin attacked you with {goblinDamage} damage!");
                        }
                        break;
                    default:
                        Console.WriteLine("Unknown command.");
                        continue; //rerun the cycle
                }
                if (player.Hp <= 0)
                {
                    player.Playerdeath();
                }
                else if (goblin.Hp <= 0)
                {
                    Console.WriteLine("Victory! The Goblin is dead.");
                }
            }
        }
    }
}

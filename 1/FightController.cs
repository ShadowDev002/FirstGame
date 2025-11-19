using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class FightController
    {
        public void Fight(SmallHealPotion currentPotion, Player player, Enemy enemy)
        {
            Random rand = new Random();
            int enemyDamage = enemy.Atk;
            int playerDamage = player.Atk;
            //fight cicle
            while (player.Hp > 0 && enemy.Hp > 0) 
            {
                Console.WriteLine($"An {enemy.Name} appeared, prepare for attack!");
                Console.WriteLine("Fight stats: ");
                Console.WriteLine($"Player HP: {player.Hp} | {enemy.Name} HP: {enemy.Hp}");
                Console.WriteLine("Choose an action: ");
                Console.WriteLine("(1). Fight");
                Console.WriteLine("(2). Defense");
                Console.WriteLine("(3). Heal");
                Console.WriteLine("(4). Run away");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        enemy.TakeDamage(playerDamage);
                        Console.WriteLine($"You attacked the {enemy.Name} for {playerDamage} damage!");
                        if (enemy.Hp > 0)
                        {
                            player.TakeDamage(enemyDamage);
                            Console.WriteLine($"The {enemy.Name} strikes back! You took {enemyDamage} damage.");
                        }
                        break;
                    case "2":
                        player.TakeDamage(enemyDamage / 2);
                        Console.WriteLine($"You defended against the {enemy.Name}'s attack! You took {enemyDamage / 2} damage.");
                        break;
                    case "3":
                        if (currentPotion.Owned > 0)
                        {
                            currentPotion.Use(player);
                            Console.WriteLine($"You used a {currentPotion.ItemName}! Current HP: {player.Hp}");
                        }
                        else {
                            Console.WriteLine($"You down own any {currentPotion.ItemName}!");
                        }
                        player.TakeDamage(enemyDamage);
                        Console.WriteLine($"{enemy.Name} attacked you with {enemyDamage} damage while you were healing!");
                        break;
                    case "4":
                        int runawayChance = rand.Next(0, 101);
                        if (runawayChance >= 30)
                        {
                            Console.WriteLine("You ran away from the fight!");
                            return; //exit the fight
                        }
                        else 
                        {
                            player.TakeDamage(enemyDamage);
                            Console.WriteLine($"Failed to run away!");
                            Console.WriteLine($"{enemy.Name} attacked you with {enemyDamage} damage!");
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
                else if (enemy.Hp <= 0)
                {
                    Console.WriteLine($"Victory! The {enemy.Name} is dead.");
                    //player.IncreaseFloor();
                }
            }
        }
    }
}

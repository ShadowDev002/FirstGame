using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class SmallHealPotion
    {
        public string ItemName { get; } = "Small Healing Potion";
        public int HealAmount { get; } = 350;
        public int Price { get; } = 10;
        public int Owned { get; private set; } = 2;

        public void Found(int amount)
        {
            Owned += amount;
        }
        public void Use(Player player) //who is using the potion
        {
            if (Owned > 0)
            {
                player.Heal(HealAmount);
                Console.WriteLine($"You used a {ItemName} and healed for {HealAmount} HP!");
                Owned--;
            }
            else
            {
                Console.WriteLine("No Small Heal Potions left to use!");
            }
        }
    }
}

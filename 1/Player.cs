using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Player
    {
        public string Name { get; set; } = "DefaultPlayer";
        public int Hp { get; private set; } = 1000;
        public int Atk { get; private set; } = 100;
        public void TakeDamage(int dmg)
        {
            Hp -= dmg;
            if (Hp <= 0)
            {
                Hp = 0;
                Playerdeath();
            }
        }
        public void Heal(int amount)
        {
            Hp += amount;
            if (Hp > 1000)
            {
                Hp = 1000;
            }
        }
        public void Playerdeath()
        {
            Console.WriteLine("You died");
        }
    }
}

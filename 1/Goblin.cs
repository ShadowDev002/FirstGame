using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{   
    internal class Goblin
    {
        public string Name { get; } = "Goblin"; 
        public int Hp { get; private set; } = 500;
        public int Atk { get; private set; } = 50;
        public void TakeDamage(int dmg)
        {
            Hp -= dmg;
            if (Hp <= 0)
            {
                Hp = 0;
            }
        }
        public void ResetHp()
        {
            Hp = 500;
        }
    }
}

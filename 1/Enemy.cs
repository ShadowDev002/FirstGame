using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Enemy
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Atk { get; set; }
        public int MaxHp { get; set; }
        public void TakeDamage(int dmg)
        {
            Hp -= dmg;
            if (Hp < 0) Hp = 0;
        }
        public void ResetHp()
        {
            Hp = MaxHp;
        }
        public static Enemy GenerateRandomEnemy()
        {
            Random r = new Random();
            int roll = r.Next(1, 3);
            if (roll == 1) return new Goblin();
            else return new Zombie();
        }
    }
}

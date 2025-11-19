using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Player
    {
        public string Name { get; set; } = "Adventurer";
        public string ClassName { get; set; } = "None"; 
        public int Hp { get; private set; }
        public int MaxHp { get; private set; }
        public int Atk { get; private set; }
        public int CurrentFloor { get; private set; } = 1;


        public void InitializeStats(PlayerClasses choice)
        {
            ClassName = choice.Name;
            Hp = choice.Hp;
            MaxHp = choice.MaxHp;
            Atk = choice.Atk;

            //Console.WriteLine($"Class set to: {ClassName} (HP: {Hp}, ATK: {Atk})");
        }
        public void IncreaseFloor()
        {
            CurrentFloor++;
        }
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
            if (Hp > MaxHp)
            {
                Hp = 1000;
            }
            Console.WriteLine($"Healed! Current HP: {Hp}/{MaxHp}");
        }
        public void Playerdeath()
        {
            Console.WriteLine("You died");
        }
    }
}

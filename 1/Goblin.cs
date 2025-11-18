using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{   
    internal class Goblin : Enemy
    {
        public Goblin()
        {
            Name = "Goblin";
            Hp = 500;
            MaxHp = 500;
            Atk = 50;
        }
    }
}

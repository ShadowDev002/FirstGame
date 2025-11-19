using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Wolf : Enemy
    {
        public Wolf() 
        {
            Name = "Wolf";
            Hp = 1000;
            MaxHp = 1000;
            Atk = 80;
        }
    }
}

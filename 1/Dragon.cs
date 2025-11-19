using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Dragon : Enemy
    {
        public Dragon() 
        {
            Name = "Red Dragon";
            Hp = 5000;
            MaxHp = 5000;
            Atk = 250;
        }
    }
}

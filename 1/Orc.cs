using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1
{
    internal class Orc : Enemy
    {
        public Orc()
        {
            Name = "Orc";
            Hp = 1500;
            MaxHp = 1500;
            Atk = 150;
        }
    }
}

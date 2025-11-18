using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1
{
    internal class Zombie : Enemy
    {
        public Zombie()
        {
            Name = "Zombie";
            Hp = 800; // Több élete van
            MaxHp = 800;
            Atk = 30; // De gyengébbet üt
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkStuding.Game
{
    class Peasant : Unit, IUnit
    {
        public Peasant(string name, int currentHealth, int maxHealth, int lvl) : base(name, currentHealth, maxHealth, lvl)
        {
        }

        public void Move()
        {
            Console.WriteLine($"{_name} is moving");
        }

        public override void Work()
        {
            Console.WriteLine("Farming food");
        }
    }
}

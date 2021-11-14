using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkStuding.Game
{
    class Castle : IBuilding
    {
        private int _durability;
        private int _armor;

        public Castle(int durability)
        {
            _durability = durability;
        }

        public int Durability
        {
            get => _durability;
            set
            {
                if (_durability <= 200)
                    Defence();
                else
                    Repair();
            }
        }

        public void Repair()
        {
            _durability += 100;
            Console.WriteLine($"Castle durability is {_durability}");
        }

        public void Defence()
        {
            _armor = 200;
            _durability += _armor;
            Console.WriteLine($"Defence mode on");
            Console.WriteLine($"Castle durability is {_durability}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkStuding.Game
{
    class Farm : IBuilding
    {
        private int _durability;
        private int _farm;

        public Farm(int durability, int farm)
        {
            _durability = durability;
            _farm = farm;
        }

        public int Durability 
        { 
            get => _durability; 
            set
            {
                if (_durability <= 20)
                    Repair();
                else
                    Farming();
            }
        }

        public void Repair()
        {
            _durability += 20;
            Console.WriteLine($"Farm durability is {_durability}");
        }

        public void Farming()
        {
            _farm += 10;
            Console.WriteLine($"Farming is available");
            Console.WriteLine($"Resources are {_farm}");
        }
    }
}

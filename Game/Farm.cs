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

        public Farm(int durability)
        {
            _durability = durability;
        }
        public int Durability 
        { 
            get => _durability; 
            set
            {
                if (_durability <= 20)
                    Repair();
            }
        }

        public void Repair()
        {
            _durability += 20;
            Console.WriteLine($"farm durability {_durability}");
        }
    }
}

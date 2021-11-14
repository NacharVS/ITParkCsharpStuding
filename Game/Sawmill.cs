using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkStuding.Game
{
    class Sawmill : IBuilding
    {
        private int _woodCount;
        private int _durability;
        private int _maxDurability = 75;

        public int WoodCount
        {
            get
            {
                return _woodCount;
            }
            set
            {
                _woodCount = value;
            }
        }
        public int Durability
        {
            get
            {
                return _durability;
            }
            set
            {
                _durability = value;
            }
        }
        public int MaxDurability
        {
            get
            {
                return _maxDurability;
            }
        }
        public Sawmill(int currentDurability)
        {
            Durability = currentDurability;
        }
        public void Repair()
        {
            Durability += 5;
            if (Durability > _maxDurability) Durability = _maxDurability;
            Console.WriteLine("Sawmill is repaired!");
        }

        public void FarmWood()
        {
            WoodCount += 10;
            Console.WriteLine("Farmed some wood");
        }
    }


}



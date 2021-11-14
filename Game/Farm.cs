using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkStuding.Game
{
    class Farm : IBuilding
    {
        private int _foodCount = 0;
        private int _maxDurability = 20;
        private int _durability;

        public int FoodCount
        {
            get
            {
                return _foodCount;
            }
            set
            {
                _foodCount = value;
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
        public Farm(int currentDurability)
        {
            Durability = currentDurability;
        }

        public void Repair()
        {
            Durability += 5;
            if (Durability > _maxDurability) Durability = _maxDurability;
            Console.WriteLine("Farm is repaired!");
        }

        public void FarmFood()
        {
            FoodCount += 10;
            Console.WriteLine("Farmed some food");
        }
    }
}

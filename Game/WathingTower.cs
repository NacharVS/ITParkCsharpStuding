using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkStuding.Game
{
    class WathingTower : IBuilding
    {
        private int _durability;
        private int _maxDurability = 100;

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
        public WathingTower(int currentDurability)
        {
            Durability = currentDurability;
        }
        public void Repair()
        {
            Durability += 20;
            if (Durability > _maxDurability) Durability = _maxDurability;
            Console.WriteLine("Watching tower is repaired!");
        }

        public void Attack()
        {
            Console.WriteLine("Tower attacked the enemy");
        }
    }
}

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
        public int Durability { get => 100; set => _durability = value; }

        public void Repair()
        {
            throw new NotImplementedException();
        }
    }
}

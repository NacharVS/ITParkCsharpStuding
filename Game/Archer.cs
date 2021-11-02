using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkStuding.Game
{
    class Archer : Unit
    {
        private int _arrowsCount;
        private int _mleeDamage;

        public Archer(int arrowsCount, int mleeDamage): base("Archer", 100, 100, 0)
        {
            _arrowsCount = arrowsCount;
            _mleeDamage = mleeDamage;
        }

        public void Shoot()
        {

        }

        private void MleeFight()
        {
            Console.WriteLine($"{_name} has chenged on mlee");
        }
    }
}

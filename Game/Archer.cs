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
        private int _rangeDamage;
        private int _mleeDamage;

        public Archer(int arrowsCount, int mleeDamage, int rangeDamage): base("Archer", 100, 100, 0)
        {
            ArrowsCount = arrowsCount;
            _mleeDamage = mleeDamage;
            _rangeDamage = rangeDamage;
        }

        public int RangeDamage => _rangeDamage;
        public int MleeDamahe => _mleeDamage;

        public int ArrowsCount { get => _arrowsCount; set => _arrowsCount = value; }


    }
}

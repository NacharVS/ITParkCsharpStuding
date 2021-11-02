using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkStuding.Game
{
    class Warrior : Unit
    {
        private int _mleeDamage;

        public Warrior(int mleeDamage) : base("Warrior", 200, 200, 0 )
        {           
            MleeDamage = mleeDamage;
        }

        public int MleeDamage { get => _mleeDamage; set => _mleeDamage = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkStuding.Game
{
    class Farm : IBuilding
    {
        public int Durability { get => 20; set => throw new NotImplementedException(); }

        public void Repair()
        {
            throw new NotImplementedException();
        }
    }
}

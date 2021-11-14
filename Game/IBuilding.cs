﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkStuding.Game
{
    interface IBuilding
    {
        int Durability { get; set; }
        int MaxDurability { get;}
        void Repair();
    }
}
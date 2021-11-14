﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkStuding.Game
{
    class WathingTower : IBuilding
    {
        private int _durability;

        public WathingTower(int durability)
        {
            _durability = durability;
        }

        public int Durability
        {
            get => _durability;
            set
            {
                if (_durability <= 200)
                {
                    Repair();
                    Alarm();
                }
            }
        }

        public void Repair()
        {
            _durability += 50;
            Console.WriteLine($"Watching tower durability {_durability}");
        }

        public void Alarm()
        {
            _durability += 100;
            Console.WriteLine($"Watching tower was attacked");
            Console.WriteLine($"Watching tower durability {_durability}");
        }
    }
}

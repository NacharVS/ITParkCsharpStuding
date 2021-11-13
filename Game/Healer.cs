using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkStuding.Game
{
    class Healer : Unit, IUnit
    {
        public Healer(string name, int currentHealth, int maxHealth, int lvl) : base(name, currentHealth, maxHealth, lvl)
        {
        }

        public void SelfHeal()
        {
            Health += 50;
            Console.WriteLine("SelfHeal");
        }

        public void Move()
        {
            Console.WriteLine($"{_name} is moving");
        }

        public override int Health 
        { 
            get => base.Health;
            set 
            {
                if (value < Health / 2)
                {
                    base.Health = value;
                    if(!IsDead)
                        SelfHeal();     

                }
                else
                    base.Health = value;
            }
        }
    }
}

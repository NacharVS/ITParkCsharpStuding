using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkStuding.Game
{
    class Healer : Unit
    {
        public Healer(string name, int currentHealth, int maxHealth, int lvl) : base(name, currentHealth, maxHealth, lvl)
        {
        }

        public void SelfHeal()
        {
            Health += 50;
            Console.WriteLine("SelfHeal");
        }

        public override int Health 
        { 
            get => base.Health;
            set 
            {
                if (value < Health / 2)
                {
                    base.Health = value;
                    SelfHeal();                    
                }
                else
                    base.Health = value;
            }
        }
    }
}

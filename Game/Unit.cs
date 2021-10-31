using System;

namespace ITParkStuding.Game
{
    class Unit
    {
        public int health;
        public int damage;
        private int _energy;
        private int _lvl;

        public Unit(int hp, int dmg, int lvlpar)
        {
            _lvl = lvlpar;
            health = hp;
            damage = dmg;
        }

        public Unit(int hp, int dmg)
        {
            _lvl = 1;
            _energy = 30;
            health = hp;
            damage = dmg;
        }

        public void LvlChange()
        {
            _lvl += 1;
        }

        public void SelfHeal()
        {
            if (_energy <= 0)
                Console.WriteLine("energy low");
            else
            {
                _energy -= 10;
                health += 10;
                if (health > 100)
                    health = 100;
            }
        }
        public static void Attack(Unit unit1, Unit unit2)
        {
            unit2.health -= new Random().Next(unit1.damage);
        }

        public void UnitInfo()
        {
            Console.WriteLine($"current health - {health}");
            Console.WriteLine($" damage - {damage}");
            Console.WriteLine($" energy - {_energy}");
            Console.WriteLine($" level -  {_lvl}");
        }

    }
    
}

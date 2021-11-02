using System;

namespace ITParkStuding.Game
{
    class Unit
    {
        private string _name;
        private int _health;
        private int _maxHealth;
        private int _damage;
        private int _energy;
        private int _lvl;    

        public Unit(string name, int hp, int dmg, int lvlpar, int max)
        {
            _name = name;
            _lvl = lvlpar;
            _health = hp;
            _damage = dmg;
            _maxHealth = max; 
        }

        public int Health 
        { 
            get => _health;
           
            private set 
            {
                if (value < 0)
                {
                    _health = 0;
                    Death();
                }
                else
                    if (value > _maxHealth)
                    _health = _maxHealth;
                else
                    _health = value;
            } 
        }
        private void Death()
        {
            Console.WriteLine("Unit dead");
        }
        public static void Attack(Unit unit1, Unit unit2)
        {
            unit2.Health -= new Random().Next(unit1._damage);
        }

        public void UnitInfo()
        {
            Console.WriteLine($"current health - {Health}");
            Console.WriteLine($" damage - {_damage}");
            Console.WriteLine($" energy - {_energy}");
            Console.WriteLine($" level -  {_lvl}");
        }

    }
    
}

using System;

namespace ITParkStuding.Game
{
    class Unit
    {
        private string _name;
        private int _currentHealth;
        private int _maxHealth;
        private int _lvl;

        public Unit(string name, int currentHealth, int maxHealth, int lvl)
        {
            _name = name;
            _currentHealth = currentHealth;
            _maxHealth = maxHealth;
            _lvl = lvl;
        }

        public int Health 
        { 
            get => _currentHealth;
           
            set 
            {
                if (value < 0)
                {
                    _currentHealth = 0;
                    Death();
                }
                else
                    if (value > _maxHealth)
                    _currentHealth = _maxHealth;
                else
                    _currentHealth = value;
            } 
        }
        private void Death()
        {
            Console.WriteLine($"{_name} dead");
        }


        public void UnitInfo()
        {
            Console.WriteLine($"current health - {Health}");
            Console.WriteLine($" level -  {_lvl}");
        }

    }
    
}

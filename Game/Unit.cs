using System;

namespace ITParkStuding.Game
{
    class Unit 
    {
        internal string _name;
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

        public bool IsDead = false;

        public virtual int Health 
        { 
            get => _currentHealth;
           
            set 
            {
                if (value < 0)
                {
                    _currentHealth = 0;
                    IsDead = true;
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

        public virtual void Work()
        {
            Console.WriteLine($"{_name} is working");
        }

        public void UnitInfo()
        {
            Console.WriteLine($"current health - {Health}");
            Console.WriteLine($" level -  {_lvl}");
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

    }
    
}

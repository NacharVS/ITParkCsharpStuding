using System;

namespace ITParkStuding.Game
{
    class Unit
    {
        public int health;
        public int damage;
        private int lvl;

        public Unit(int hp, int dmg, int lvlpar)
        {
            lvl = lvlpar;
            health = hp;
            damage = dmg;
        }

        public Unit(int hp, int dmg)
        {
            lvl = 1;
            health = hp;
            damage = dmg;
        }

        public void LvlChange()
        {
            lvl += 1;
        }

        public static void Attack(Unit unit1, Unit unit2)
        {
            unit2.health -= new Random().Next(unit1.damage);
        }

        public void UnitInfo()
        {
            Console.WriteLine($"current health - {health}");
            Console.WriteLine($" damage - {damage}");
            Console.WriteLine($" level -  {lvl}");
        }

    }
    
}

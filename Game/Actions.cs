using System;

namespace ITParkStuding.Game
{
    class Actions
    {
        public static void Fight(Warrior war1, Warrior war2)
        {
            war1.Health -= war2.MleeDamage;
        }

        public static void RangeFight(Archer archer)
        {
           if(archer.ArrowsCount > 0)
            {
                Console.WriteLine(archer.RangeDamage);
                archer.ArrowsCount -= 1;
            }
            else
            {
                Console.WriteLine(archer.MleeDamahe);
            }
        }
    }
}

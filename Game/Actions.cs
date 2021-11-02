using System;

namespace ITParkStuding.Game
{
    class Actions
    {
        public static void Fight(Warrior war1, Warrior war2)
        {
            war1.Health -= war2.MleeDamage;
        }
    }
}

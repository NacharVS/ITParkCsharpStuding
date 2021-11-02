using ITParkStuding.Game;
using System;
using System.Threading;

namespace ITParkStuding
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n > 1)
                return n * Factorial(n - 1);
            else
                return 1;
        }
        
        static void ArrayGenerator(int[]array, int a, int b)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(a,b);
                Console.Write($" {array[i]}");
            }
        }
        static void ArrayGenerator(int[] array, int a)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(a);
                Console.Write($" {array[i]}");
            }
        }

        static void Main(string[] args)
        {
            Warrior war1 = new Warrior(20);
            Warrior war2 = new Warrior(30);

            Actions.Fight(war1, war2);
            war1.UnitInfo();
            Actions.Fight(war1, war2);
            war1.UnitInfo();
            Actions.Fight(war1, war2);
            war1.UnitInfo();
            Actions.Fight(war1, war2);
            war1.UnitInfo();
            Actions.Fight(war1, war2);
            war1.UnitInfo();
            Actions.Fight(war1, war2);
            war1.UnitInfo();
            Actions.Fight(war1, war2);
            war1.UnitInfo();








        }
    }
}

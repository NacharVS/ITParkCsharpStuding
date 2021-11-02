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
            Unit unit1 = new Unit("Valera", 100, 50, 0, 100);
            Unit unit2 = new Unit("Ivan", 100, 20, 0, 100);

            Unit.Attack(unit1, unit2);
            unit2.UnitInfo();
            Unit.Attack(unit1, unit2);
            unit2.UnitInfo();
            Unit.Attack(unit1, unit2);
            unit2.UnitInfo();

            
            
            

        }
    }
}

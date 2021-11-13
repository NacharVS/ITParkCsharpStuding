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
            IBuilding farm = new Farm(15);
            IBuilding sawmill = new Sawmill(50);
            IBuilding wt = new WathingTower(80);
            
            Console.WriteLine($"Farm's HP: {farm.Durability}/{farm.MaxDurability}");
            farm.Repair();
            Console.WriteLine($"Farm's HP: {farm.Durability}/{farm.MaxDurability}");
            Console.ReadKey();









        }
    }
}

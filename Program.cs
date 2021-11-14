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
            Farm farm = new Farm(20, 0);
            farm.Farming();
            Console.WriteLine();

            WathingTower watchTow = new WathingTower(200);
            watchTow.Alarm();
            Console.WriteLine();

            Castle castle = new Castle(200);
            castle.Defence();
            Console.WriteLine();
        }
    }
}

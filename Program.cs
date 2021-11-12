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
            
            try
            {
                int[] ads = new int[3];
                Console.WriteLine();
                for (int i = 0; i <= ads.Length; i++)
                {
                    Console.WriteLine(ads[i] = i);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }










        }
    }
}

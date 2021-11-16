using ITParkStuding.Game;
using System;
using System.Collections.Generic;
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
            DelegatesEvents ec = new DelegatesEvents();
            ec.ValueChangedEvent += Method1;
            ec.ValueChangedEvent += Method1;
            ec.Number = 5;         
            Console.WriteLine(DelegatesEvents.taxRate);
         

        }

        static void Method1(int n)
        {
            Console.WriteLine(n);
        }
        static void Method2()
        {
            Console.WriteLine("value changedvalue changed");
        }
        static void Method3()
        {
            Console.WriteLine("value changedvalue changedvalue changed");
        }
    }
}

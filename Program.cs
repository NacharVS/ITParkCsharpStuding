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
            List<int> numbers = new List<int>();
            List<int> number2 = new List<int>();
            numbers.Add(1);
            numbers.Add(22);
            numbers.Add(23);
            numbers.Add(3232);
            numbers.Add(11);
            numbers.Add(32);
            number2.AddRange(numbers);
            number2.AddRange(numbers);
            number2.AddRange(numbers);
            if (number2.Contains(111))
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");











        }
    }
}

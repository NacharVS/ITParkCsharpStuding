using ITParkStuding.Game;
using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

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
            Task newTask = new Task(
                () => Method1(5)
                //{
                //    for (int i = 0; i < 10; i++)
                //    {
                //        Thread.Sleep(1000);
                //        Console.WriteLine("#");
                //    }
                //    Console.WriteLine("task end");
                //}
                );
            newTask.Start();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("*");
            }
            newTask.Wait();
            Console.WriteLine("main end");

            
        }

        static async Task Method1(int n)
        {
            

        }
        static void Method2()
        {
            Console.WriteLine("value changedvalue changed");
        }
        static void Method3()
        {
            Console.WriteLine("value changedvalue changedvalue changed");
        }
        static void Method4()
        {
            Console.WriteLine("value changedvalue changedvalue changed");
        }
    }
}

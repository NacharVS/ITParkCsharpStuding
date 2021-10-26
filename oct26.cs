using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ITParkStuding
{
    class oct26
    {
        public static void Array2dGenegation()
        {
            int[,] array = new int[10, 10];

            int summ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                 
                        array[i, j] = new Random().Next(10);
                        summ += array[i, j];
                        Console.Write($" {array[i, j]} ");
                    
                }
                Console.WriteLine();
            }
        }
        public static void ArraySort()
        {

            int[] array1 = new int[10];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = new Random().Next(100);
                Console.Write($" {array1[i]}");
            }
            Console.WriteLine();

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array1.Length - 1 - i; j++)
                {
                    Thread.Sleep(100);
                    if (array1[j] > array1[j + 1])
                    {
                        int buffer = array1[j];
                        array1[j] = array1[j + 1];
                        array1[j + 1] = buffer;
                    }

                }
            }

            foreach (var item in array1)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();

        }
        public static void SummDifferentArrays()
        {
            int[] array1 = new int[10];
            int[] array2 = new int[15];

         

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = new Random().Next(10);
                Console.Write($" {array1[i]}");              
            }
            Console.WriteLine();
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = new Random().Next(10);
                Console.Write($" {array2[i]}");
            }
            Console.WriteLine();

            if (array1.Length > array2.Length)
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    array1[i] = array1[i] + array2[i];                   
                }
                foreach (var item in array1)
                {
                    Console.Write($" {item}");
                }
            }
            else
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    array2[i] = array2[i] + array1[i];
                }
                foreach (var item in array2)
                {
                    Console.Write($" {item}");
                }
            }
        }
    }
}

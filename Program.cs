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
            //Farm farm = new Farm(20, 0);
            //farm.Farming();
            //Console.WriteLine();

            //WathingTower watchTow = new WathingTower(200);
            //watchTow.Alarm();
            //Console.WriteLine();

            //Castle castle = new Castle(200);
            //castle.Defence();
            //Console.WriteLine();


            //DelegatesEvents ec = new DelegatesEvents();
            //ec.ValueChangedEvent += Method1;
            //ec.ValueChangedEvent += Method1;
            //ec.Number = 5;
            //Console.WriteLine(DelegatesEvents.taxRate);

            Person person = new Person("Ivan", "Ivanov", "economist", 20, 123456);
            Person person1 = new Person("Ivan", "Sergeev", "manager", 30, 123654);
            Person person2 = new Person("Sergey", "Ivanov", "administrator", 35);
            Person person3 = new Person("John", "Ivanov", "administrator", 35);

            try
            {
                //Person.AddToDataBase(person);
                //Person.AddToDataBase(person1);
                //Person.AddToDataBase(person2);
                //Person.GetFromDataBase("Sergey", "Ivanov");
                Person.ReplaceDocument(person3, "Sergey");
            }

            catch
            {

            }
            

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
        static void Method4()
        {
            Console.WriteLine("value changedvalue changedvalue changed");
        }
    }
}

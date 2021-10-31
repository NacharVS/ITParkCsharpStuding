using System;

namespace ITParkStuding
{
    class oct24
    {
        public void SimpleMultiplicators()
        {
            int a = 256;
            int multiplicator = 2;

            while(a > 1)
            {
                if(a % multiplicator == 0)
                {
                    Console.WriteLine(multiplicator);
                    a = a / multiplicator;
                }
                else
                {
                    multiplicator++;
                }
            }
        }

        static void CountOfSeven()
        {
            int N = int.Parse(Console.ReadLine());
            int countOfSeven = 0;

            for (int i = 1; i < N; i++)
            {
                int buffer = i;
                while (buffer > 0)
                {
                    if (buffer % 10 == 7)
                        countOfSeven++;
                    buffer = buffer / 10;
                }

            }
            Console.WriteLine(countOfSeven);
        }
        static void SummOfDigits()
        {
            ulong a = ulong.Parse(Console.ReadLine());
            ulong summ = 0;
            while (a > 0)
            {
                summ = summ + a % 10;
                a = a / 10;
            }
            Console.WriteLine(summ);
        }
        static void powerAB()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int counter = 0;
            int resuilt = 1;

            while (b > 0)
            {
                counter++;
                resuilt = resuilt * a;
                b--;
                Console.WriteLine($" iteration {counter}");
            }

            Console.WriteLine($"res - {resuilt}");
            Console.WriteLine(b);
        }
        static void Combinations()
        {
            int sumOfDigits = int.Parse(Console.ReadLine());
            int count = 0;
            Console.WriteLine("start");
            // 0 1 2 3 4 
            // 5 6 7 8 9      12
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (i + j + k == sumOfDigits)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
            Console.WriteLine("end");
        }
    }
}

using System;

namespace _03._Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double evenSum = 0;
            double oddSum = 0;
            double evenMax = 0;
            double oddMax = 0;
            double evenMin = 0;
            double oddMin = 0; ;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());


                if (i % 2 == 0)
                {
                    if (i == 2)
                    {
                        evenMin = num;
                        evenMax = num;
                    }
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    if (i == 1)
                    {
                        oddMin = num;
                        oddMax = num;
                    }
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }

                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");

            if (oddMin == 0 || oddMax == 0)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }

            Console.WriteLine($"EvenSum={evenSum:f2},");

            if (evenMin == 0 || evenMax == 0)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}

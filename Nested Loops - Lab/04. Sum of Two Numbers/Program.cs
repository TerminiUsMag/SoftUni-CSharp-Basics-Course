using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int a = begin; a <= end; a++)
            {
                for (int b = begin; b <= end; b++)
                {
                    counter++;
                    if (a + b == num)
                    {
                        Console.WriteLine($"Combination N:{counter} ({a} + {b} = {num})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {num}");

        }
    }
}

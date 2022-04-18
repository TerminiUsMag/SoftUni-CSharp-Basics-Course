using System;

namespace _08._Number_sequence
{
    class Program 
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = 0;
            int min = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    max = num;
                    min = num;
                }

                if (num > max) max = num;
                if (num < min) min = num;
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}

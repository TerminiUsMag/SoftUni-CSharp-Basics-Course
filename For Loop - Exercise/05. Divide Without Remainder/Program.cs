using System;

namespace _05._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());

            //p1 % 2 == 0;
            //p2 % 3 == 0;
            //p3 % 4 = 0;

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            double percentP1 = 0;
            double percentP2 = 0;
            double percentP3 = 0;

            for (int i = 1; i <= n; i++)
            {

                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0) p1++;
                if (num % 3 == 0) p2++;
                if (num % 4 == 0) p3++;

            }

            percentP1 = p1 / n * 100;
            percentP2 = p2 / n * 100;
            percentP3 = p3 / n * 100;

            Console.WriteLine($"{percentP1:f2}%");
            Console.WriteLine($"{percentP2:f2}%");
            Console.WriteLine($"{percentP3:f2}%");
        }
    }
}

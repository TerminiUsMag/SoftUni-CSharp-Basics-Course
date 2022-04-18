using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {

            double n = int.Parse(Console.ReadLine());
            //p1 < 200
            //p2 from 200 to 399
            //p3 from 400 to 599
            //p4 from 600 to 799
            //p5 >= 800
            double percentP1 = 0;
            double percentP2 = 0;
            double percentP3 = 0;
            double percentP4 = 0;
            double percentP5 = 0;

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200) p1++;
                else if (num <= 399) p2++;
                else if (num <= 599) p3++;
                else if (num <= 799) p4++;
                else if (num >= 800) p5++;

            }

            percentP1 = p1 / n * 100;
            percentP2 = (p2 / n) * 100;
            percentP3 = (p3 / n) * 100;
            percentP4 = (p4 / n) * 100;
            percentP5 = (p5 / n) * 100;

            Console.WriteLine($"{percentP1:f2}%");
            Console.WriteLine($"{percentP2:f2}%");
            Console.WriteLine($"{percentP3:f2}%");
            Console.WriteLine($"{percentP4:f2}%");
            Console.WriteLine($"{percentP5:f2}%");

        }
    }
}

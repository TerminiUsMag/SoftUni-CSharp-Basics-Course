using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());
            int sumSec = sec1 + sec2 + sec3;
            double secLeft = sumSec % 60;
            int minutes = sumSec / 60;
            // Console.WriteLine(secLeft);
            // Console.WriteLine(minutes);

            if(secLeft <=9)
            {
                Console.WriteLine($"{minutes}:0{secLeft}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{secLeft}");
            }

        }
    }
}

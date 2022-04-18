using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            int totalMins = hours * 60 + mins + 15;
            int totalHours = totalMins / 60;
            totalMins = totalMins % 60;

            if(totalHours > 23)
            {
                totalHours = 0;
            }

            if (totalMins <= 9)
            {
                Console.WriteLine($"{totalHours}:0{totalMins}");
            }
            else
            {
                Console.WriteLine($"{totalHours}:{totalMins}");
            }

        }
    }
}

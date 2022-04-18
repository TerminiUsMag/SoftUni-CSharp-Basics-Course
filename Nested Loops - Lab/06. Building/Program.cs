using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            int counter1 = 0, counter2 = -1;

            for (int a = floors; a >= 1; a--)
            {
                
                for (int b = rooms; b >= 1; b--)
                {
                    counter2++;
                    if (a == floors)
                    {
                        Console.Write($"L{a}{counter2} ");
                    }
                    else if (a % 2 == 0)
                    {
                        Console.Write($"O{a}{counter2} ");
                    }
                    else if (a % 2 == 1)
                    {
                        Console.Write($"A{a}{counter2} ");
                    }
                    if (b == 1) counter2 = -1;

                }
                        Console.WriteLine();
            }

        }
    }
}

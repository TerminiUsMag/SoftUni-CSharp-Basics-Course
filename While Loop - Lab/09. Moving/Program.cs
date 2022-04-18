using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int freeSpace = width * lenght * height;
            int needed = 0;
            string input = Console.ReadLine();
            while(input != "Done")
            {
                    needed += int.Parse(input);

                if (freeSpace < needed)
                {
                    Console.WriteLine($"No more free space! You need {needed-freeSpace} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if(input == "Done")
            {
                Console.WriteLine($"{freeSpace-needed} Cubic meters left.");
            }
        }
    }
}

using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthApartment = int.Parse(Console.ReadLine());
            int lengthApartment = int.Parse(Console.ReadLine());
            int heightApartment = int.Parse(Console.ReadLine());
            int totalFreeSpace = widthApartment * lengthApartment * heightApartment;
            int freeSpaceLeft = totalFreeSpace;
            int boxes;
            bool isDone = false;
            bool stop = false;
            string command;

            while (!stop)
            {
                command = Console.ReadLine();
                if (command == "Done")
                {
                    isDone = true;
                    stop = true;
                    break;
                }
                boxes = int.Parse(command);
                freeSpaceLeft -= boxes;
                if (freeSpaceLeft <= 0)
                {
                    stop = true;
                    break;
                }
            }
            if (isDone && freeSpaceLeft > 0)
            {
                Console.WriteLine($"{freeSpaceLeft} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeSpaceLeft)} Cubic meters more.");
            }



        }
    }
}

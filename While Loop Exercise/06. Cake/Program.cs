using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtCake = int.Parse(Console.ReadLine());
            int widthCake = int.Parse(Console.ReadLine());
            int totalPieces = lenghtCake * widthCake;
            int people = 0;
            string people1;
            bool stop = false;
            bool command = false;
            while (!stop)
            {
                people1 = Console.ReadLine();
                if (people1 == "STOP")
                {
                    command = true;
                    stop = true;
                    break;
                }
                people = int.Parse(people1);
                totalPieces -= people;
                if (totalPieces <= 0)
                {
                    stop = true;
                }
            }
            if (command)
            {
                Console.WriteLine($"{totalPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
            }
        }
    }
}

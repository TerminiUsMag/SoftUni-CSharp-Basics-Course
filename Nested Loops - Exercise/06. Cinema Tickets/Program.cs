using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfMovie = Console.ReadLine();
            double seats = 0, student = 0, standard = 0, kids = 0, totalTickets = 0, seatsTaken = 0;
            double percentPerMovie = 0;

            while (nameOfMovie != "Finish")
            {
                seats = int.Parse(Console.ReadLine());

                for (int a = 1; a <= seats; a++)
                {
                    string type = Console.ReadLine();
                    if (type == "student") student++;
                    if (type == "standard") standard++;
                    if (type == "kid") kids++;
                    if (type == "End") break;
                    else
                    {
                        totalTickets++;
                        seatsTaken = a;
                    }
                }
                percentPerMovie = (seatsTaken / seats);
                percentPerMovie *= 100;
                Console.WriteLine($"{nameOfMovie} - {percentPerMovie:f2}% full.");
                nameOfMovie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{100 * (student / totalTickets):f2}% student tickets.");
            Console.WriteLine($"{100 * (standard / totalTickets):f2}% standard tickets.");
            Console.WriteLine($"{100 * (kids / totalTickets):f2}% kids tickets.");
        }
    }
}

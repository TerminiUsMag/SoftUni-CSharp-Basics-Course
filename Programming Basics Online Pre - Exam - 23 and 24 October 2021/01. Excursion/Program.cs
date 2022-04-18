using System;

namespace _01._Excursion
{
    class Program
    {
        static void Main(string[] args)
        {

            // Нощувка - 20 лв.
            // Карта за транспорт - 1.60 лв.
            // Билет за музей - 6 лв.

            int people = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int cards = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());

            double nightPrice = 20;
            double cardPrice = 1.60;
            double ticketPrice = 6;

            double pricePerPerson, priceForGroup, result;
            pricePerPerson = (nights * nightPrice) + (cards * cardPrice) + (tickets * ticketPrice);
            priceForGroup = pricePerPerson * people;
            result = priceForGroup + (priceForGroup / 4);

            Console.WriteLine($"{result:f2}");
        }
    }
}

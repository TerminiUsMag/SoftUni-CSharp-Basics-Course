using System;

namespace _05._Birthday_party
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceHall = double.Parse(Console.ReadLine());
            double cake =(0.2*priceHall);
            double drinks = cake - (0.45 * cake);
            double animator = priceHall / 3;
            double budget = priceHall + cake + drinks + animator;
            Console.WriteLine(budget);

        }
    }
}

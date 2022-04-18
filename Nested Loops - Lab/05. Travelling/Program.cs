using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double budget = 0;
            double money = 0;
            while (destination != "End")
            {
                budget = double.Parse(Console.ReadLine());
                while (money < budget)
                {
                    money += double.Parse(Console.ReadLine());
                }
                money = 0;
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}

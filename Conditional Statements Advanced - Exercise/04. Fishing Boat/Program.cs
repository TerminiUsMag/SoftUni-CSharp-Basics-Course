using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            double priceShip = 0;
            double discount = 0;

            switch (season)
            {
                case "Spring":
                    priceShip = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    priceShip = 4200;
                    break;
                case "Winter":
                    priceShip = 2600;
                    break;
                default:
                    break;
            }
            if(fishers <= 6)
            {
                discount = 0.1;
            }
            else if(fishers >=7 && fishers <= 11)
            {
                discount = 0.15;
            }
            else 
            {
                discount = 0.25;
            }
            priceShip -= priceShip * discount;

            if (fishers % 2 == 0 && season != "Autumn")
            {
                priceShip -= priceShip * 0.05;
            }
            if(budget >= priceShip)
            {
                double moneyLeft = budget - priceShip;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = priceShip - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
        }
    }
}

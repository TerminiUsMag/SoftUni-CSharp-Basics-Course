using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            //coffee water   beer sweets  peanuts
            double coffee = 0;
            double water = 0;
            double beer = 0;
            double sweets = 0;
            double peanuts = 0;

            double priceProduct = 0;
            double product1 = 0;

            switch (city)
            {
                case "Sofia":
                    coffee = 0.5;
                    water = 0.8;
                    beer = 1.20;
                    sweets = 1.45;
                    peanuts = 1.60;
                    break;
                case "Plovdiv":
                    coffee = 0.4;
                    water = 0.7;
                    beer = 1.15;
                    sweets = 1.30;
                    peanuts = 1.50;
                    break;
                case "Varna":
                    coffee = 0.45;
                    water = 0.70;
                    beer = 1.10;
                    sweets = 1.35;
                    peanuts = 1.55;
                    break;
                default:
                    break;
            }
            switch (product)
            {
                case "coffee":
                    product1 = coffee;
                    break;
                case "water":
                    product1 = water;
                    break;
                case "beer":
                    product1 = beer;
                    break;
                case "sweets":
                    product1 = sweets;
                    break;
                case "peanuts":
                    product1 = peanuts;
                    break;
                default:
                    break;
            }
            priceProduct = product1 * quantity;
            Console.WriteLine(priceProduct);
        }
    }
}

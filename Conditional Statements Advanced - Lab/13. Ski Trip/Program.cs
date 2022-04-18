using System;

namespace _13._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string feedback = Console.ReadLine();
            double costPerNight = 0;
            double discount = 0;
            double priceWithDiscount = 0;
            double priceWithoutDiscount = 0;
            double finalPrice = 0;


            switch (room)
            {
                case "room for one person":
                    costPerNight = 18;
                    discount = 0;
                    break;
                case "apartment":
                    costPerNight = 25;
                    if (days < 10)
                    {
                        discount = 0.3;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.35;
                    }
                    else if (days > 15)
                    {
                        discount = 0.5;
                    }
                    break;
                case "president apartment":
                    costPerNight = 35;
                    if (days < 10)
                    {
                        discount = 0.1;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount = 0.15;
                    }
                    else if (days > 15)
                    {
                        discount = 0.2;
                    }
                    break;
                default:
                    break;
            }
            priceWithoutDiscount = costPerNight * (days - 1);
            priceWithDiscount = priceWithoutDiscount - (priceWithoutDiscount * discount);

            if (feedback == "positive")
            {
                finalPrice = priceWithDiscount + (priceWithDiscount * 0.25);
            }
            else if (feedback == "negative")
            {

                finalPrice = priceWithDiscount - (priceWithDiscount * 0.1);
            }

            Console.WriteLine($"{finalPrice:f2}");

        }
    }
}

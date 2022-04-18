using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double result = 0;
            string type = "";

            //•	При 100лв.или по-малко – някъде в България
            //o   Лято – 30 % от бюджета
            //o   Зима – 70 % от бюджета
            //•	При 1000лв.или по малко – някъде на Балканите
            //o   Лято – 40 % от бюджета
            //o   Зима – 80 % от бюджета
            //•	При повече от 1000лв. – някъде из Европа
            //o   При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета.
            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        type = "Camp";
                        result = (budget * 0.3);
                        break;
                    case "winter":
                        type = "Hotel";
                        result = (budget * 0.7);
                        break;
                }
            }
            else if(budget <=1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        type = "Camp";
                        result = (budget * 0.4);
                        break;
                    case "winter":
                        type = "Hotel";
                        result = (budget * 0.8);
                        break;
                }
            }
            else
            {
                type = "Hotel";
                destination = "Europe";
                        result = (budget * 0.9);
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {result:F2}");

        }
    }
}

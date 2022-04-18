using System;

namespace _05._Hair_Salon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Подстригване(haircut):
            //o Мъжко(mens) -15лв.
            //o Дамско(ladies) – 20лв.
            //o Детско(kids) – 10лв.
            // Боядисване(color):
            //o Поддръжка(touch up) – 20лв.
            //o Пълно боядисване(full color) – 30лв.

            int targetForTheDay = int.Parse(Console.ReadLine());
            string service = Console.ReadLine();
            double money = 0;
            bool targetIsReached = false;

            while (service != "closed" && targetIsReached == false)
            {
                if (service == "haircut")
                {
                    string haircut = Console.ReadLine();
                    if (haircut == "mens") money += 15;
                    else if (haircut == "ladies") money += 20;
                    else if (haircut == "kids") money += 10;
                }

                else if (service == "color")
                {
                    string color = Console.ReadLine();
                    if (color == "touch up") money += 20;
                    else if (color == "full color") money += 30;
                }
                if (money >= targetForTheDay) targetIsReached = true;
                service = Console.ReadLine();
            }
            if (targetIsReached)
            {
                Console.WriteLine($"You have reached your target for the day!");
            }
            else
            {
                Console.WriteLine($"Target not reached! You need {targetForTheDay-money}lv. more.");
            }
            Console.WriteLine($"Earned money: {money}lv.");
        }
    }
}

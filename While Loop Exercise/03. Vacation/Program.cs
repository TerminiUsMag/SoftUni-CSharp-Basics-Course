using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int consecuentiveI = 0;
            double moneyNeeded = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            string activity = "";
            double amount = 0;
            bool isFailed = false;
            bool savedTheMoney = false;
            while (!isFailed)
            {
                i++;
                activity = Console.ReadLine();
                amount = double.Parse(Console.ReadLine());
                if(activity == "spend")
                {
                    consecuentiveI++;
                    money -= amount;
                    if (money < 0) money = 0;
                }
                else
                {
                    money += amount;
                    consecuentiveI = 0;
                    if(money >= moneyNeeded)
                    {
                        savedTheMoney = true;
                        break;
                    }
                }
                if(consecuentiveI >= 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(i);
                    break;
                }
            }
            if (savedTheMoney)
            {
                Console.WriteLine($"You saved the money for {i} days.");
            }

        }
    }
}

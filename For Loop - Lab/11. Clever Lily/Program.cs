using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWasher = double.Parse(Console.ReadLine());
            double priceToys = double.Parse(Console.ReadLine());
            double sumMoney = 0;
            int sumMoneyPerYear = 10;
            int numberOfToys = 0;


            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sumMoney += sumMoneyPerYear - 1;
                    sumMoneyPerYear += 10;
                }
                else
                {
                    numberOfToys++;
                }
            }
            sumMoney += (numberOfToys * priceToys);

            if (priceWasher > sumMoney)
            {
                Console.WriteLine($"No! {priceWasher - sumMoney:f2}");
            }
            else
            {
                Console.WriteLine($"Yes! {sumMoney - priceWasher:f2}");
            }

        }
    }
}

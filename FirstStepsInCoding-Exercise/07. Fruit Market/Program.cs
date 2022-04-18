using System;

namespace _07._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceStrawberry = double.Parse(Console.ReadLine());
            double quantityOfBannanas = double.Parse(Console.ReadLine());
            double quantityOfOranges = double.Parse(Console.ReadLine());
            double quantityOfMalini = double.Parse(Console.ReadLine());
            double quantityOfStrawberries = double.Parse(Console.ReadLine());

            double priceMalini = priceStrawberry / 2;
            double priceOranges = priceMalini - (priceMalini * 0.4);
            double priceBannanas = priceMalini - (priceMalini * 0.8);

            double moneyNeededForStrawberries = priceStrawberry * quantityOfStrawberries;
            double moneyNeededForMalini = priceMalini * quantityOfMalini;
            double moneyNeededForOranges = priceOranges * quantityOfOranges;
            double moneyNeededForBannanas = priceBannanas * quantityOfBannanas;

            double moneyNeededByMaria = moneyNeededForStrawberries + moneyNeededForMalini + moneyNeededForOranges + moneyNeededForBannanas;

            Console.WriteLine(Math.Round(moneyNeededByMaria,2));


        }
    }
}

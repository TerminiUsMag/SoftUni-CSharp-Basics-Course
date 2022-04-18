using System;

namespace _07._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double puzzle = 2.60;
            double doll = 3;
            double tedyBear = 4.10;
            double minion = 8.20;
            double truck = 2;

            double moneyNeeded = double.Parse(Console.ReadLine());
            int numPuzzles = int.Parse(Console.ReadLine());
            int numDolls = int.Parse(Console.ReadLine());
            int numTedyBear = int.Parse(Console.ReadLine());
            int numMinion = int.Parse(Console.ReadLine());
            int numTrucks = int.Parse(Console.ReadLine());
            int totalNumToys = numDolls + numMinion + numPuzzles + numTedyBear + numTrucks;
            double puzzlePrice = puzzle * numPuzzles;
            double dollPrice = doll * numDolls;
            double tedyBearPrice = tedyBear * numTedyBear;
            double minionPrice = minion * numMinion;
            double truckPrice = truck * numTrucks;
            double orderPrice = puzzlePrice + dollPrice + tedyBearPrice + minionPrice + truckPrice;
            double orderPriceAfterDiscount = orderPrice;
            double moneyLeftAfterLoan;
            double moneyAfterAll;

            if (totalNumToys >= 50)
            {
                orderPriceAfterDiscount = orderPrice - (orderPrice * 0.25);
                moneyLeftAfterLoan = orderPriceAfterDiscount - (orderPriceAfterDiscount * 0.1);
            }
            else
            {
                moneyLeftAfterLoan = orderPrice - (orderPrice *0.1);
            }

            if (moneyLeftAfterLoan >= moneyNeeded)
            {
                moneyAfterAll = moneyLeftAfterLoan - moneyNeeded;
                Console.WriteLine($"Yes! {moneyAfterAll:F2} lv left.");
            }
            else
            {
                moneyAfterAll = moneyNeeded - moneyLeftAfterLoan;
                Console.WriteLine($"Not enough money! {moneyAfterAll:F2} lv needed.");
            }
        }
    }
}

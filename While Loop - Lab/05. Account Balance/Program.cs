using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSum = 0;
            string input = Console.ReadLine();

            while (input != "NoMoreMoney")
            {
                double moneyInput = double.Parse(input);
                if (moneyInput >= 0)
                {
                    Console.WriteLine($"Increase: {moneyInput:f2}");
                    totalSum += moneyInput;
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}

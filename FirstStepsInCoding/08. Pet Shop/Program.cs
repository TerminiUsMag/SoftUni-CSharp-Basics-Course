using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogs = int.Parse(Console.ReadLine());
            int numberOfOtherAnimals = int.Parse(Console.ReadLine());
            double priceDogFood = 2.50;
            double priceOtherFood = 4;
            double result = numberOfDogs * priceDogFood + numberOfOtherAnimals * priceOtherFood;
            Console.WriteLine($"{result} lv.");
        }
    }
}

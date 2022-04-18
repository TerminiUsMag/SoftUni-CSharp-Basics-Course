using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double pricePerMeter = 7.61;
            double discount = 0.18;
            double price = area * pricePerMeter;
            double discountInMoney = discount * price;
            double finalPrice = price - discountInMoney;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discountInMoney} lv.");


        }
    }
}

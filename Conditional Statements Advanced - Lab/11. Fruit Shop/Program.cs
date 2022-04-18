using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //banana apple   orange grapefruit  kiwi pineapple   grapes

            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            bool wrongDayOfWeek = false;
            bool wrongFruitName = false;
            //fruits
            double bananaPrice = 0;
            double applePrice = 0;
            double orangePrice = 0;
            double grapefruitPrice = 0;
            double kiwiPrice = 0;
            double pineapplePrice = 0;
            double grapesPrice = 0;

            double priceOfFruit = 0;


            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    bananaPrice = 2.50;
                    applePrice = 1.20;
                    orangePrice = 0.85;
                    grapefruitPrice = 1.45;
                    kiwiPrice = 2.70;
                    pineapplePrice = 5.50;
                    grapesPrice = 3.85;
                    break;
                case "Saturday":
                case "Sunday":
                    bananaPrice = 2.70;
                    applePrice = 1.25;
                    orangePrice = 0.90;
                    grapefruitPrice = 1.60;
                    kiwiPrice =3.00;
                    pineapplePrice = 5.60;
                    grapesPrice = 4.20;
                    break;
                default:
                    wrongDayOfWeek = true;
                    break;
            }
            switch (fruit)
            {
                case "banana":
                    priceOfFruit = bananaPrice * quantity;
                    break;
                case "apple":
                    priceOfFruit = applePrice * quantity;
                    break;
                case "orange":
                    priceOfFruit = orangePrice * quantity;
                    break;
                case "grapefruit":
                    priceOfFruit = grapefruitPrice * quantity;
                    break;
                case "kiwi":
                    priceOfFruit = kiwiPrice * quantity;
                    break;
                case "pineapple":
                    priceOfFruit = pineapplePrice * quantity;
                    break;
                case "grapes":
                    priceOfFruit = grapesPrice * quantity;
                    break;
                default:
                    wrongFruitName = true;
                    break;
            }
            if(wrongFruitName || wrongDayOfWeek)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{priceOfFruit:f2}");
            }

        }
    }
}

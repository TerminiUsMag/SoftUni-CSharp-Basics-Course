using System;

namespace _02._Deer_of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double foodForFirstDeerPerDay = double.Parse(Console.ReadLine());
            double foodForSecondDeerPerDay = double.Parse(Console.ReadLine());
            double foodForThirdDeerPerDay = double.Parse(Console.ReadLine());

            double foodForFirstDeer = days * foodForFirstDeerPerDay;
            double foodForSecondDeer = days * foodForSecondDeerPerDay;
            double foodForThirdDeer = days * foodForThirdDeerPerDay;

            double foodNeeded = foodForFirstDeer + foodForSecondDeer + foodForThirdDeer;

            if (food >= foodNeeded)
            {
                Console.WriteLine($"{Math.Floor(food-foodNeeded)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeeded-food)} more kilos of food are needed.");
            }


        }
    }
}

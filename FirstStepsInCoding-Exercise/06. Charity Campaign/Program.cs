using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCampaign = int.Parse(Console.ReadLine());
            int numberOfCooks = int.Parse(Console.ReadLine());
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());
            double cakes = numberOfCakes * 45;
            double waffles = numberOfWaffles * 5.8;
            double pancakes = numberOfPancakes * 3.2;
            double sumPerCook = cakes + waffles + pancakes;
            double sumPerDay = numberOfCooks * sumPerCook;
            double sumWholeCampaign = sumPerDay * daysCampaign;
            double result = sumWholeCampaign - (sumWholeCampaign/8);
            Console.WriteLine(result);


        }
    }
}

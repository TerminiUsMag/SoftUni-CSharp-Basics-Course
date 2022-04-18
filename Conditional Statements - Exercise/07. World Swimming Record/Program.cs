using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            //2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            //3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]

            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secsPerMeter = double.Parse(Console.ReadLine());
            double secondsNeededWithoutWater = secsPerMeter * meters;
            double water1 = Math.Floor(meters / 15);
            double water = water1 * 12.5;
            double secondsNeededWithWater = (secondsNeededWithoutWater + water);
            double secsNeededToBeat = record - secondsNeededWithWater;
            secsNeededToBeat = (secsNeededToBeat);
            secondsNeededWithWater = (secondsNeededWithWater);

            if(secondsNeededWithWater < record )
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {secondsNeededWithWater:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(secsNeededToBeat):f2} seconds slower.");
            }
        }
    }
}

using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfTest = int.Parse(Console.ReadLine());
            int minuteOfTest = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());

            int hourOfTestInMinutes = hourOfTest * 60 + minuteOfTest;
            int hourOfArrivalInMinutes = hourOfArrival * 60 + minuteOfArrival;
            int diff = hourOfTestInMinutes - hourOfArrivalInMinutes;
            int resultHour = 0;
            int resultMinutes = 0;
            bool isOnTime;
            bool isLate;
            bool isLateUnderHour;
            bool isLateMoreThanHour;
            bool isEarly;
            bool isEarlyButInTime;
            bool isEarlyMoreThanHour;

            if (diff > -60 && diff < 0)
            {
                isLateUnderHour = true;
                Console.WriteLine("Late");
                resultMinutes = Math.Abs(diff);
                Console.WriteLine($"{resultMinutes} minutes after the start");
            }
            else if (diff <= -60)
            {
                isLateMoreThanHour = true;
                Console.WriteLine("Late");
                resultMinutes = Math.Abs(diff % 60);
                resultHour = Math.Abs(diff / 60);
                if (resultMinutes >= 0 && resultMinutes <= 9)
                {
                    Console.WriteLine($"{resultHour}:0{resultMinutes} hours after the start");
                }
                else
                {

                    Console.WriteLine($"{resultHour}:{resultMinutes} hours after the start");
                }
            }
            if (diff >= 0 && diff <= 30)
            {
                if (diff > 0)
                {
                    isEarlyButInTime = true;
                    resultMinutes = diff;
                    Console.WriteLine("On Time");
                    Console.WriteLine($"{resultMinutes} minutes before the start");
                }
                else
                {
                    isOnTime = true;
                    Console.WriteLine("On time");
                }
            }
            else if (diff > 30 && diff < 60)
            {
                isEarly = true;
                Console.WriteLine("Early");
                resultMinutes = diff;
                Console.WriteLine($"{resultMinutes} minutes before the start");
            }
            else if (diff >= 60)
            {
                isEarlyMoreThanHour = true;
                Console.WriteLine("Early");
                resultMinutes = diff % 60;
                resultHour = diff / 60;
                if (resultMinutes >= 0 && resultMinutes <= 9)
                {
                    Console.WriteLine($"{resultHour}:0{resultMinutes} hours before the start");
                }
                else
                {

                    Console.WriteLine($"{resultHour}:{resultMinutes} hours before the start");
                }

            }

        }
    }
}

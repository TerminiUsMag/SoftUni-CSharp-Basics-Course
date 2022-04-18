using System;

namespace _9._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            double holidaysInYear = double.Parse(Console.ReadLine());
            double weeksHome = double.Parse(Console.ReadLine());

            const double WEEKS_IN_YEAR = 48;
            const double TWO_THIRDS = 0.66;
            const double THREE_FORTHS = 0.75;
            double weeksInSofia = WEEKS_IN_YEAR - weeksHome;
            double gamesInSofia = (weeksInSofia * THREE_FORTHS)+(holidaysInYear *TWO_THIRDS);
            double SumGamesInSofiaAndHome = gamesInSofia + weeksHome;

            if(yearType == "leap")
            {
                SumGamesInSofiaAndHome += SumGamesInSofiaAndHome * 0.15;
            }

            Console.WriteLine(Math.Floor(SumGamesInSofiaAndHome));


        }
    }
}

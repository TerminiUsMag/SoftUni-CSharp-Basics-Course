using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //	Декорът за филма е на стойност 10 % от бюджета.
            //	При повече от 150 статиста,  има отстъпка за облеклото на стойност 10 %.
            //Ред 1.Бюджет за филма – реално число в интервала[1.00 … 1000000.00]
            //Ред 2.Брой на статистите – цяло число в интервала[1 … 500]
            //Ред 3.Цена за облекло на един статист – реално число в интервала[1.00 … 1000.00]

            double budget = double.Parse(Console.ReadLine());
            int numberStatists = int.Parse(Console.ReadLine());
            double clothPerStatist = double.Parse(Console.ReadLine());
            double totalPriceCloth = 0;
            double decorPrice = budget * 0.1;
            double result = 0;

            if (numberStatists > 150)
            {
                clothPerStatist = clothPerStatist - (clothPerStatist * 0.1);
            }

            totalPriceCloth = clothPerStatist * numberStatists;
            result = budget - (totalPriceCloth + decorPrice);
            if(result >= 0 )
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {result:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs { Math.Abs(result):f2} leva more.");
            }
        }
    }
}

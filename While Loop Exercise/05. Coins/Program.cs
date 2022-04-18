using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double changeLeft = change + 0.000001;
            int coins = 0;
            while (changeLeft != 0)
            {
                if (changeLeft >= 2)
                {
                    coins++;
                    changeLeft -= 2;
                }
                if (changeLeft >= 1 && changeLeft < 2)
                {
                    coins++;
                    changeLeft -= 1;
                }
                if (changeLeft >= 0.5 && changeLeft < 1)
                {
                    coins++;
                    changeLeft -= 0.500000000;
                }
                if (changeLeft >= 0.2 && changeLeft < 0.5)
                {
                    coins++;
                    changeLeft -= 0.20;
                }
                if (changeLeft >= 0.1 && changeLeft < 0.2)
                {
                    coins++;
                    changeLeft -= 0.10;
                }
                if (changeLeft >= 0.05 && changeLeft < 0.1)
                {
                    coins++;
                    changeLeft -= 0.05;
                }
                if (changeLeft >= 0.02 && changeLeft < 0.05)
                {
                    coins++;
                    changeLeft -= 0.02;
                }
                if (changeLeft >= 0.01 && changeLeft < 0.02)
                {
                    coins++;
                    changeLeft -= 0.01;
                }
                if (changeLeft < 0.01 && changeLeft > 0.005)
                {
                    coins++;
                    changeLeft -= 0.01;
                }
                if (changeLeft < 0.005)
                {
                    break;
                }
            }
            Console.WriteLine(coins);

        }
    }
}

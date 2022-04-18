using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool noneZero = true;

            for (int a = 1111; a <= 9999; a++)
            {
                string currentNumber = a.ToString();
                int digit1 = int.Parse(currentNumber[0].ToString());
                int digit2 = int.Parse(currentNumber[1].ToString());
                int digit3 = int.Parse(currentNumber[2].ToString());
                int digit4 = int.Parse(currentNumber[3].ToString());
                if (digit1 == 0 || digit2 == 0 || digit3 == 0 || digit4 == 0) noneZero = false;
                if (noneZero&& n % digit1 == 0 && n % digit2 == 0 && n % digit3 == 0 && n % digit4 == 0)
                {
                    Console.Write(a + " ");
                }
                noneZero = true;
            }
        }
    }
}

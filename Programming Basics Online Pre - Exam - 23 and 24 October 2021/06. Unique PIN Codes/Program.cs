using System;

namespace _06._Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxFirstNumber = int.Parse(Console.ReadLine());
            int maxSecondNumber = int.Parse(Console.ReadLine());
            int maxThirdNumber = int.Parse(Console.ReadLine());

            for (int a = 1; a <= maxFirstNumber; a++)
            {
                if (a % 2 == 0)
                {
                    for (int b = 2; b <= maxSecondNumber; b++)
                    {
                        if (b == 2 || b == 3 || b == 5 || b == 7)
                        {
                            for (int c = 1; c <= maxThirdNumber; c++)
                            {
                                if (c % 2 == 0)
                                {
                                    Console.Write(a + " ");
                                    Console.Write(b + " ");
                                    Console.WriteLine(c + " ");
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}

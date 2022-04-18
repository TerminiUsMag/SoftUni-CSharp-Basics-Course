using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter1 = 0, counter2 = 0;
            bool isBigger = false;
            for (int a = 1; a <= num + 1; a++)
            {
                counter1++;
                for (int b = 1; b <= counter1; b++)
                {
                    counter2++;
                    if (counter2 > num)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(counter2 + " ");
                }
                if (isBigger) break;
                Console.WriteLine();
            }

        }
    }
}

using System;

namespace _07._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum1 = 0;
            for (int i = 0; i < nn; i++)
            {
                sum1 = int.Parse(Console.ReadLine());
                sum += sum1;
            }
            Console.WriteLine(sum);
        }
    }
}

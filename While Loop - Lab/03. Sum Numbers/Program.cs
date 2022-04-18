using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());
            int sumNum = int.Parse(Console.ReadLine());
            while (sumNum < endNum)
            {
                sumNum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sumNum);
        }
    }
}

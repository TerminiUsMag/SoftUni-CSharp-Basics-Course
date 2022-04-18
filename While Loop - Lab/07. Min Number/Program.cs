using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = 0;
            int i = 0;
            int minNum = 0;
            while (input != "Stop")
            {
                num = int.Parse(input);
                if (i == 0)
                    minNum = num;
                i++;
                if (num < minNum)
                {
                    minNum = num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}

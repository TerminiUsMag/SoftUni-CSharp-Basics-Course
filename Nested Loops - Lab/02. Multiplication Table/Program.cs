using System;

namespace _02._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int fistNum = 1; fistNum <= 10; fistNum++)
            {
                for(int secondNum = 1; secondNum <= 10; secondNum++)
                {
                    Console.WriteLine($"{fistNum} * {secondNum} = {fistNum*secondNum}");
                }
            }
        }
    }
}

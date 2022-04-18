using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int isPrime = 0, sumPrime = 0, sumNonPrime = 0;
            while (input != "stop")
            {
                int num = int.Parse(input);
                if (num > 0 && num < 10) isPrime--;
                for (int a = 1; a < 10; a++)
                {
                    if (num < 0)
                    {
                        Console.WriteLine("Number is negative.");
                        break;
                    }
                    if (num % a == 0) isPrime++;
                }
                if (isPrime == 1 && num > 0)
                {
                    sumPrime += num;
                }
                else if (isPrime != 0 && num > 0)
                {
                    sumNonPrime += num;
                }
                isPrime = 0;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}

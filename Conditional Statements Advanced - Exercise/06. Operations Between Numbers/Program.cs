using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    int sum = n1 + n2;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} + {n2} = {sum} - odd");
                    }
                    break;
                case "-":
                    int diff = n1 - n2;
                    if (diff % 2 == 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {diff} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} - {n2} = {diff} - odd");
                    }
                    break;
                case "*":
                    int result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} * {n2} = {result} - odd");
                    }
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        double division = n1 * 1.0 / n2;
                        Console.WriteLine($"{n1} / {n2} = {division:F2}");
                    }
                    break;
                case "%":
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        int leftover = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {leftover}");
                    }
                    break;
                default:
                    break;
            }

        }
    }
}

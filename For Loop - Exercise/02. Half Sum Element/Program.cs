using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = 0;
            for (int i = 0; i < nn; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }
            sum -= max;
            if(sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - max)}");
            }

        }
    }
}

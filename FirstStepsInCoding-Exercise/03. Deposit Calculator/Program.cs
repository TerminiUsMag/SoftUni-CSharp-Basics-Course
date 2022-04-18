using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double yearlyPercent = double.Parse(Console.ReadLine());
            yearlyPercent /= 100;
            double monthysum = (deposit * yearlyPercent)/12;
            double result = deposit + (period * monthysum) ;
            Console.WriteLine(result);
        }
    }
}

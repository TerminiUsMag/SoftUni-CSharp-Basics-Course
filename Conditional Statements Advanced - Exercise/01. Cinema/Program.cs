using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProject = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double people = r * c;
            double price = 0;
            double result = 0;


            switch (typeProject)
            {
                case "Premiere":
                    price = 12;
                    break;
                case "Normal":
                    price = 7.5;
                    break;
                case "Discount":
                    price = 5;
                    break;
                default:
                    break;
            }
            result = price * people;
            Console.WriteLine($"{result:f2} leva");
        }
    }
}

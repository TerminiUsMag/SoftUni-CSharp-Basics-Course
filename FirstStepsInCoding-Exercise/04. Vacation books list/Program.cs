using System;

namespace _04._Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesInBook = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int daysToRead = int.Parse(Console.ReadLine());
            double timeToRead = pagesInBook / pagesPerHour;
            double result = timeToRead / daysToRead;
            Console.WriteLine(result);

        }
    }
}

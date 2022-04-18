using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            string book = Console.ReadLine();
            int i = 1;
            while (searchedBook != book)
            {
                if(book == "No More Books")
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {i-1} books.");
                    break;
                }
                i++;
                book = Console.ReadLine();
            }
            if(book == searchedBook)
            {
                Console.WriteLine($"You checked {i-1} books and found it.");
            }
        }
    }
}

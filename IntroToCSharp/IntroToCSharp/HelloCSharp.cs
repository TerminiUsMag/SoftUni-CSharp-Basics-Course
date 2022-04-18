using System;

namespace IntroToCSharp
{
    class HelloCSharp
    {
        static void Main()
        {
            Console.WriteLine("Enter your fucking name here :");
            String Name = Console.ReadLine();
            // for(int x=0;x<5;x++)
            //{
            Console.Beep();
            //}

            Console.WriteLine("Your name is : " +
                Name +
                "\r\n Is that right?(Y/N)");
            bool confirmed = false;
            ConsoleKey response;
            do
            {
                Console.Write("Are you sure you want to choose this as your login key? [y/n] ");
                response = Console.ReadKey(false).Key;   // true is intercept key (dont show), false is show
                if (response != ConsoleKey.Enter)
                    Console.WriteLine();

            } while (response != ConsoleKey.Y && response != ConsoleKey.N);
            {

                confirmed = response == ConsoleKey.Y;
            }
            while (!confirmed) ;
            {
                Console.WriteLine("You chose {0}!", Name);
                Console.ReadLine();
            }
        }
    }
} 

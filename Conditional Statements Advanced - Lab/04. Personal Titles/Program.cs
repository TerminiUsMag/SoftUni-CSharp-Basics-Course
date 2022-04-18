using System;

namespace _04._Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double years = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (gender == "m")
            { 
            if(years >= 16)
                {
                    Console.WriteLine("Mr.");
                }
            else
                {
                    Console.WriteLine("Master");
                }
            }
            else if(gender == "f")
            {
                if(years >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}

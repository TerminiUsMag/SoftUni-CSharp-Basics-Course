using System;

namespace _05._Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int length = word.Length;

            for (int i = 0; i <= length -1; i++)
            {
                Console.WriteLine(word[i]);
            }

        }
    }
}

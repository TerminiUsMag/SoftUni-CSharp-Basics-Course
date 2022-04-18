using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int sum=0;
            int length = word.Length;
            //буква       a   e   i   o   u
            //стойност    1   2   3   4   5
            for (int i = 0; i <= length - 1; i++)
            {
                switch(word[i])
                {
                    case 'a':
                        sum++;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }

            }
            Console.WriteLine(sum);

        }
    }
}

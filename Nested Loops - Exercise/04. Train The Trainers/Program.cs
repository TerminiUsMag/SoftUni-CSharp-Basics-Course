using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), counter = 0;
            string presentationName = Console.ReadLine();
            double score = 0, middleScore = 0, finalScore = 0;
            while (presentationName != "Finish")
            {
                for (int a = 0; a < n; a++)
                {
                    score += double.Parse(Console.ReadLine());
                }
                middleScore = score / n;
                Console.WriteLine($"{presentationName} - {middleScore:f2}.");
                finalScore += middleScore;
                counter++;
                score = 0;
                presentationName = Console.ReadLine();
            }
            finalScore = finalScore / counter;
            Console.WriteLine($"Student's final assessment is {finalScore:f2}.");
        }
    }
}

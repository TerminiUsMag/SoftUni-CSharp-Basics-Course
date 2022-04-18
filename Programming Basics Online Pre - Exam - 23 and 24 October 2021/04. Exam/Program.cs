using System;

namespace _04._Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double fiveGroup = 0, fourGroup = 0, threeGroup = 0, twoGroup = 0;
            double fiveGroupPercent, fourGroupPercent, threeGroupPercent, twoGroupPercent;
            double average = 0,averageScore = 0;
            for (int i = 0; i < students; i++)
            {
                double score = double.Parse(Console.ReadLine());
                average += score;
                if (score < 3)
                {
                    twoGroup++;
                }
                else if (score >= 3 && score < 4)
                {
                    threeGroup++;
                }
                else if (score >= 4 && score < 5)
                {
                    fourGroup++;
                }
                else if (score >= 5)
                {
                    fiveGroup++;
                }
            }

            fiveGroupPercent = (fiveGroup / students) * 100;
            fourGroupPercent = (fourGroup / students) * 100;
            threeGroupPercent = (threeGroup / students) * 100;
            twoGroupPercent = (twoGroup / students) * 100;
            averageScore = average / students;

            Console.WriteLine($"Top students: {fiveGroupPercent:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {fourGroupPercent:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {threeGroupPercent:f2}%");
            Console.WriteLine($"Fail: {twoGroupPercent:f2}%");
            Console.WriteLine($"Average: {averageScore:f2}");
        }
    }
}
using System;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int i = 1;
            int f = 0;
            double averageGrade = 0;
            double grade = 0;
            while (i <= 12)
            {
                grade = double.Parse(Console.ReadLine());
                averageGrade += grade;
                if (grade < 4) f++;
                if(f > 1)
                {
                    Console.WriteLine($"{name} has been excluded at {i-1} grade");
                    break;
                }
                if (i == 12)
                {
                    averageGrade = averageGrade / 12;
                    Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
                    break;
                }
                i++;
            }
        }
    }
}

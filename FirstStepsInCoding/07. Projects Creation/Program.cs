using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfArchitect = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            double timePerProject = 3;
            double result = numberOfProjects * timePerProject;

            Console.WriteLine($"The architect {nameOfArchitect} will need {result} hours to complete {numberOfProjects} project/s.");
        }
    }
}

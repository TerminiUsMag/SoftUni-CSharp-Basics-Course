using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int totalSteps = 0;
            int steps = 0;
            bool isReady = false;
            string s = Console.ReadLine();
            while (s!="Going home")
            {
                steps = int.Parse(s);
                totalSteps += steps;
                if(totalSteps >= goal)
                {
                    isReady = true;
                    break;
                }
                s = Console.ReadLine();
            }
            if(s=="Going home")
            {
                steps = int.Parse(Console.ReadLine());
                totalSteps += steps;
                if (totalSteps >= goal)
                {
                    isReady = true;
                }
            }
            if (isReady)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - goal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{goal-totalSteps} more steps to reach goal.");
            }
        }
    }
}

using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = int.Parse(Console.ReadLine());
            int fscores = 0;
            string quest = Console.ReadLine();
            string lastQuest = "";
            int score = 0;
            int i = 0;
            double averageScore = 0;
            while (quest != "Enough")
            {
                score = int.Parse(Console.ReadLine());
                averageScore += score;
                lastQuest = quest;
                i++;
                if(score <= 4)
                {
                    fscores++;
                }
                if(fscores >= f)
                {
                    Console.WriteLine($"You need a break, {fscores} poor grades.");
                    break;
                }
                quest = Console.ReadLine();
            }
            if(quest == "Enough")
            {
                Console.WriteLine($"Average score: {averageScore/i:f2}");
                Console.WriteLine($"Number of problems: {i}");
                Console.WriteLine($"Last problem: {lastQuest}");
            }
        }
    }
}

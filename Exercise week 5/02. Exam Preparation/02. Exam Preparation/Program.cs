using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filedTimes = int.Parse(Console.ReadLine());

            int evaluationSum = 0;
            int evaluationCount = 0;
            int filedCount = 0;
            string lastExercise = string.Empty;
            int evaluation;

            string input = Console.ReadLine();

            while(input != "Enough")
            {
                lastExercise = input;
                evaluation = int.Parse(Console.ReadLine());
                evaluationCount++;
                evaluationSum += evaluation;

                if (evaluation <= 4)
                {
                    filedCount++;
                    if (filedCount == filedTimes)
                    {
                        Console.WriteLine($"You need a break, {filedCount} poor grades.");
                        break;
                    }
                }
                input = Console.ReadLine();
            }
            if (input == "Enough")
            {
                Console.WriteLine($"Average score: {(double)evaluationSum/evaluationCount:f2}");
                Console.WriteLine($"Number of problems: {evaluationCount}");
                Console.WriteLine($"Last problem: {lastExercise}");
            }
        }
    }
}

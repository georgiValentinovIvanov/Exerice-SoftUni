using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int episodMin = int.Parse(Console.ReadLine());
            int lunchTime = int.Parse(Console.ReadLine());

            double timeForEpisod = lunchTime * 5 / 8.0;

            if (timeForEpisod >= episodMin)
            {
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(timeForEpisod - episodMin)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(episodMin - timeForEpisod)} more minutes.");
            }
            
        }
    }
}

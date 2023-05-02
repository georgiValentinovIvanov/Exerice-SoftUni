using System;

namespace _02._Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayOff = int.Parse(Console.ReadLine());
            int dayOffGames = 127;
            int afterWorkGames = 63;
            int oneYear = 365;
            int normTom = 30000;
            int dayOffRestGames = dayOff * dayOffGames;
            int gamesInWorkingDays = (oneYear - dayOff) * afterWorkGames;
            int totalTime = dayOffRestGames + gamesInWorkingDays;
            int games = Math.Abs(normTom - totalTime);
            double hours = games / 60;
            double minutes = games % 60;

            if (totalTime > normTom)
            {

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else if (normTom> totalTime)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}

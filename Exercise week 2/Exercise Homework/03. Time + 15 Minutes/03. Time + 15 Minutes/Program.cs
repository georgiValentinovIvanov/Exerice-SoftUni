using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int minutesAfterMin = min + 15;

            if (hour >= 0 && hour <= 23 && minutesAfterMin >= 60)
            {
                hour++;
                if (hour == 24)
                {
                    hour = 0;
                }
                min = (minutesAfterMin) % 60;
                Console.WriteLine("{0}:{1}", hour, min.ToString().PadLeft(2, '0'));
            }
            else
            {
                min = (minutesAfterMin) % 60;
                Console.WriteLine("{0}:{1}", hour, min.ToString().PadLeft(2, '0'));
            }
        }
    }
}
        
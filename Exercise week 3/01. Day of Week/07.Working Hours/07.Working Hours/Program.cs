using System;

namespace _07.Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (day == "Sunday" || hour > 18 || hour < 10)
            {
                Console.WriteLine("closed");

            }
            else
            {
                Console.WriteLine("open");
            }

        }
    }
}

using System;
using System.Diagnostics.CodeAnalysis;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string placeInHoliday = "";
            double sum = 0;
            string place = "";
            string placeOfSummer = "Camp";
            string placeOfWinter = "Hotel";

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    place = "Bulgaria";
                    sum = budget * 0.30;
                    placeInHoliday = placeOfSummer;
                }
                else if (season == "winter")
                {
                    place = "Bulgaria";
                    sum = budget * 0.70;
                    placeInHoliday = placeOfWinter;
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    place = "Balkans";
                    sum = budget * 0.40;
                    placeInHoliday = placeOfSummer;
                }
                else if (season == "winter")
                {
                    place = "Balkans";
                    sum = budget * 0.80;
                    placeInHoliday = placeOfWinter;
                }
            }
            else if (budget > 1000)
            {
                place = "Europe";
                if (season == "summer" || season == "winter")
                {
                    sum = budget * 0.90;
                    placeInHoliday = placeOfWinter;
                }
            }
            double totalSum = budget - sum;
            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{placeInHoliday} - {sum:f2}");

        }
    }
}

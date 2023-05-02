using System;

namespace P01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int cards = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());

            double sumNights = nights * 20;
            double sumCards = cards * 1.60;
            double sumTickets = tickets * 6;

            double totalSum = sumNights + sumCards + sumTickets;
            double fitalSum = peopleCount * totalSum;
            double generalSum = fitalSum + (fitalSum * 0.25);

            Console.WriteLine($"{generalSum:f2}");
        }
    }
}

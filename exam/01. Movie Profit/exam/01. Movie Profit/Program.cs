using System;

namespace _01._Movie_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double priceTickets = double.Parse(Console.ReadLine());
            int precentForCinema = int.Parse(Console.ReadLine());
            double precent = precentForCinema / 100.0;

            double sum = tickets * priceTickets;
            double sumsMount = days * sum;
            double total = precent*sumsMount;
            double fitalSum = sumsMount - total;

            Console.WriteLine($"The profit from the movie {movieName} is {fitalSum:f2} lv.");

        }
    }
}

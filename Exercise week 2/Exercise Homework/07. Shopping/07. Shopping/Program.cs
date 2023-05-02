using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCarts = int.Parse(Console.ReadLine());
            int procesors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double videoCartsPrice = videoCarts * 250;
            double procesorsCost = videoCartsPrice * 0.35;
            double procesorsPrice = procesorsCost * procesors;
            double ramCost = videoCartsPrice * 0.10;
            double ramPrice = ramCost * ram;
            double sum = videoCartsPrice + procesorsPrice + ramPrice;
           
            if (videoCarts > procesors)
            {
                sum -= sum * 0.15;
            }
            if (sum <= budget)
            {
                Console.WriteLine($"You have {Math.Abs(sum - budget):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget- sum):f2} leva more!");
            }
        }
    }
}

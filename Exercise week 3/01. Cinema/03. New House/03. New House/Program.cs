using System;
using System.Diagnostics;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double sum = 0.0;
            double priceRoses = quantity * 5.0;
            double priceDahlias = quantity * 3.80;
            double priceTulips = quantity * 2.80;
            double priceNarcissus = quantity * 3.0;
            double priceGladiolus = quantity * 2.50;

            

            if (flowers == "Roses")
            {
                if (quantity > 80)
                {
                    sum = priceRoses - (priceRoses * 0.10);
                }
                else
                {
                    sum = priceRoses;
                }

            }
            else if (flowers == "Dahlias")
            {
                if (quantity > 90)
                {
                    sum = priceDahlias - (priceDahlias * 0.15);
                }
                else
                {
                    sum = priceDahlias;
                }
            }
            else if (flowers == "Tulips")
            {
                if (quantity > 80)
                {
                    sum = priceTulips - (priceTulips * 0.15);
                }
                else
                {
                    sum = priceTulips;
                }
            }
            else if (flowers == "Narcissus")
            {
                if (quantity < 120)
                {
                    sum = priceNarcissus * 1.15;
                }
                else
                {
                    sum = priceNarcissus;
                }
            }
            else if (flowers == "Gladiolus")
            {
                if (quantity < 80)
                {
                    sum = priceGladiolus * 1.20;
                }
                else
                {
                    sum = priceGladiolus;
                }
            }
            double remainder = budget - sum;
            double needsum = sum - budget;
            if (sum <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flowers} and {remainder:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {needsum:F2} leva more.");
            }
        }
    }
}

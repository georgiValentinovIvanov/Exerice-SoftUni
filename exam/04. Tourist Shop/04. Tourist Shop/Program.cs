using System;
using System.Data;

namespace _04._Tourist_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string productName;

            int count = 0;
            double totalPrice = 0;

            while ((productName = Console.ReadLine()) != "Stop")
            {
                double productPrice = double.Parse(Console.ReadLine());
                count++;
                if (count % 3 == 0)
                {
                    productPrice /= 2;
                }
                totalPrice += productPrice;
                if (totalPrice > budget)
                {
                    break;
                }
            }   
            if (totalPrice>budget)
            {
                    double moneyNeeded = totalPrice - budget;
                    Console.WriteLine($"You don't have enough money!");
                    Console.WriteLine($"You need {moneyNeeded:f2} leva!");
            }
            else
            {
                Console.WriteLine($"You bought {count} products for {totalPrice:f2} leva.");
            }
        }
    }
}

using System;

namespace _04._Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double vegetableKg = double.Parse(Console.ReadLine());
            double fruitKg = double.Parse(Console.ReadLine());

            double euro = 1.94;

            double euroTotal = ((vegetableKg * vegetablePrice) + (fruitKg * fruitPrice)) / euro;
            Console.WriteLine($"{euroTotal:f2}");
        }
    }
}

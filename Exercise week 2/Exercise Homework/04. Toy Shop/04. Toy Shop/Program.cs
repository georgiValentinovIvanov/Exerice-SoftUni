using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());

            int puzzelsQuantity = int.Parse(Console.ReadLine());
            int dollsQuantity = int.Parse(Console.ReadLine());
            int bearsQuantity = int.Parse(Console.ReadLine());
            int minionsQuantity = int.Parse(Console.ReadLine());
            int trucksQuantity = int.Parse(Console.ReadLine());

            int toysQuantity = puzzelsQuantity + dollsQuantity + bearsQuantity + minionsQuantity + trucksQuantity;

            double money = puzzelsQuantity * 2.60 + dollsQuantity * 3 + bearsQuantity * 4.10 + minionsQuantity * 8.2 + trucksQuantity * 2;

            if (toysQuantity >= 50)
            {
                money -= money * 0.25;
            }
            money -= money * 0.10;
            if (money >= holidayPrice)
            {
                Console.WriteLine($"Yes! {money - holidayPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {holidayPrice - money:f2} lv needed.");
            }
        }
    }
}

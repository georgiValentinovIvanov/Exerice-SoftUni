using System;
using System.Collections.Concurrent;

namespace P02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double shirt = double.Parse(Console.ReadLine());
            double sumNeededToWinTheBall = double.Parse(Console.ReadLine());

            double shorts = shirt * 0.75;
            double socks = shorts * 0.20;
            double buttons = (shirt + shorts) * 2;

            double sum = shirt + shorts + socks + buttons;
            double totalSum = sum - (sum * 0.15);


            if (totalSum>=sumNeededToWinTheBall)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalSum:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {(sumNeededToWinTheBall-totalSum):f2} lv. more.");
            }
        }
    }
}

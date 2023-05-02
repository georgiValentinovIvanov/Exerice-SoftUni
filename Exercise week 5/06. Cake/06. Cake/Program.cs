using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int sum = lenght * width;

            string input = Console.ReadLine();
            int cakePeieces;

            while (input != "STOP")
            {
                cakePeieces = int.Parse(input);
                if (cakePeieces>sum)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakePeieces-sum)} pieces more.");
                    sum -= cakePeieces;
                    break;
                }
                sum -= cakePeieces;
                input = Console.ReadLine();
            }
            if (sum>0)
            {
                Console.WriteLine($"{sum} pieces are left.");
            }
                
        }
    }
}

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double b11 = 8;
            double b22 = 13;
            double h1 = 7;

            double area = (b11 + b22) * h1 / 2;

            Console.WriteLine($"{area:f2}");

        }
    }
}
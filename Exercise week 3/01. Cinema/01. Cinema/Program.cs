using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            double income = row * col;

            if (type == "Premiere")
            {
                income *= 12;
            }
            else if (type =="Normal")
            {
                income *= 7.50;
            }
            else
            {
                income *= 5.00;
            }
            Console.WriteLine("{0:f2} leva", income);
        }
    }
}

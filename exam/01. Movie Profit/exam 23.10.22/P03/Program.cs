using System;

namespace P03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double tax = 0;
            double discount = 0;
            double sum = 0;
            if (people<=5)
            {
                if (season=="spring")
                {
                    tax = 50.00;
                    sum = people * tax;
                    
                }
                else if (season=="summer")
                {
                    tax = 48.50;
                    sum = people * tax;
                    discount = sum - (sum * 0.15);
                }
                else if (season=="autumn")
                {
                    
                    tax = 60.00;
                    sum = people * tax;
                }
                else if (season=="winter")
                {
                    tax = 86.00;
                    sum = people * tax;
                    discount = sum + (sum * 0.08);

                }
            }
            else if (people>5)
            {
                if (season=="spring")
                {
                    tax = 48.00;
                    sum = people * tax;
                }
                else if (season=="summer")
                {
                    tax = 45.00;
                    sum = people * tax;
                    discount = sum - (sum * 0.15);
                }
                else if (season=="autumn")
                {
                    tax = 49.50;
                    sum = people * tax;
                }
                else if (season=="winter")
                {
                    tax = 85.00;
                    sum = people * tax;
                    discount = sum + (sum * 0.08);
                }
            }
            if (season == "summer" || season == "winter")
            {
                Console.WriteLine($"{discount:f2} leva.");
            }
            else
            {
                Console.WriteLine($"{sum:f2} leva.");
            }

        }
    }
}

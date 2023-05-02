using System;

namespace _02._Family_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Transactions;
            using System.Xml.Schema;

namespace _02._Family_Trip
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                double budget = double.Parse(Console.ReadLine());
                int nights = int.Parse(Console.ReadLine());
                double priceNights = double.Parse(Console.ReadLine());
                int precentExpenses = int.Parse(Console.ReadLine());



                if (nights > 7)
                {
                    priceNights -= priceNights * 0.05;

                }



                double total = (precentExpenses / 100.0) * budget;
                double sum = (priceNights * nights) + total;


                if (budget >= sum)
                {

                    Console.WriteLine($"Ivanovi will be left with {budget - sum:f2} leva after vacation.");
                }
                else
                {

                    Console.WriteLine($"{sum - budget:f2} leva needed.");
                }

            }
        }
    }

}
    }
}

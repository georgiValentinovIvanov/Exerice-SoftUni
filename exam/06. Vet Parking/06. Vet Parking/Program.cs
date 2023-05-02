using System;

namespace _06._Vet_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double totalFee = 0;

            for (int day = 1; day <= days ; day++)
            {
                double dailyFee = 0;

                for (int hour = 1; hour <=hours; hour++)
                {
                    if (day % 2==0 && hour%2 != 0)
                    {
                        dailyFee += 2.50;

                    }
                    else if (day % 2 != 0 && hour % 2 == 0)
                    {
                        dailyFee += 1.25;
                    }
                    else
                    {
                        dailyFee += 1;
                    }
                }

                
                totalFee += dailyFee;
                Console.WriteLine($"Day: {day} - {dailyFee:f2} leva");
            }

            Console.WriteLine($"Total: {totalFee:f2} leva");

        }
    }
}

using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeStay = int.Parse(Console.ReadLine());
            string specRoom = Console.ReadLine();
            string price = Console.ReadLine();

            int night = timeStay - 1;
            double sum = 0;
            
            
            
            string room1 = "room for one person";
            string room2 = "apartment";
            string room3 = "president apartment";

            if (specRoom==room1)
            {
                sum = night * 18.00;
            }
            else if (specRoom==room2)
            {
                sum = night * 25.00;
                if (timeStay<=10)
                {
                    sum *= 0.70;
                }
                else if (timeStay>10 && timeStay<=15)
                {
                    sum *= 0.65;
                }
                else
                {
                    sum *= 0.50;
                }
            }
            else if (specRoom==room3)
            {
                sum = night * 35.00;
                if (timeStay<=10)
                {
                    sum *= 0.90;
                }
                else if (timeStay>10 && timeStay<=15)
                {
                    sum *= 0.85;
                }
                else
                {
                    sum *= 0.80;
                }
            }
            if (price=="positive")
            {
                sum *= 1.25;
            }
            else
            {
                sum *= 0.90;
            }
            
            Console.WriteLine($"{sum:f2}");

        }
    }
}

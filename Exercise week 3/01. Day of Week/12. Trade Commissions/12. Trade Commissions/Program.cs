using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double obem = double.Parse(Console.ReadLine());
            
            double commision = -1.0;

            if (town == "Sofia")
            {
                if (obem >= 0 && obem <= 500)
                {
                    commision = 0.05;
                }
                else if (obem > 500 && obem <= 1000)
                {
                    commision = 0.07;
                }
                else if (obem > 1000 && obem <= 10000)
                {
                    commision = 0.08;
                }
                else if (obem > 10000)
                {
                    commision = 0.12;
                }

            }
            else if (town == "Varna")
            {
                if (obem >= 0 && obem <= 500)
                {
                    commision = 0.045;
                }
                else if (obem > 500 && obem <= 1000)
                {
                    commision = 0.075;
                }
                else if (obem > 1000 && obem <= 10000)
                {
                    commision = 0.1;
                }
                else if (obem > 10000)
                {
                    commision = 0.13;
                }

            }
            else if (town == "Plovdiv")
            {
                if (obem >= 0 && obem <= 500)
                {
                    commision = 0.055;
                }
                else if (obem > 500 && obem <= 1000)
                {
                    commision = 0.08;
                }
                else if (obem > 1000 && obem <= 10000)
                {
                    commision = 0.12;
                }
                else if (obem > 10000)
                {
                    commision = 0.145;
                }
            }
            if (commision < 0.0)
            {
                    Console.WriteLine("error");
            }
            else
            {
                    double result = obem * commision;
                    Console.WriteLine($"{result:f2}");
            }
            
            
        }
    
    }
}

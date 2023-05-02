using System;
using System.Transactions;

namespace _03._Gymnastics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string appliance = Console.ReadLine();
            double grade = 0;
            
            if (appliance=="ribbon")
            {
                if (country=="Russia")
                {
                    grade = 9.1 + 9.4;
                }
                else if (country=="Bulgaria")
                {
                    grade = 9.6 + 9.4;
                }
                else if (country=="Italy")
                {
                    grade = 9.2 + 9.5;
                }
            }
            else if (appliance=="hoop")
            {
                if (country=="Russia")
                {
                    grade = 9.3 + 9.8;
                }
                else if (country=="Bulgaria")
                {
                    grade = 9.55 + 9.75;
                }
                else if (country=="Italy")
                {
                    grade = 9.45 + 9.35;
                }
            }
            else if (appliance=="rope")
            {
                if (country=="Russia")
                {
                    grade = 9.6 + 9;
                }
                else if (country=="Bulgaria")
                {
                    grade = 9.5 + 9.4;
                }
                else if (country=="Italy")
                {
                    grade = 9.7 + 9.15;
                }
            }
            double pointsToMax = 20 - grade;
            double precentToMax = (pointsToMax / 20) * 100;
            Console.WriteLine($"The team of {country} get {grade:f3} on {appliance}.");
            Console.WriteLine($"{precentToMax:f2}%");
        }
    }
}

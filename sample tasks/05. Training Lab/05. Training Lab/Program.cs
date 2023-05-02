using System;

namespace _05._Training_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine())-1;

            double places = Math.Floor(w / 1.2);
            double rows = Math.Floor((h /0.7));
            
            double workPlaces = (rows * places) - 3;



            Console.WriteLine("{0:f0}",workPlaces);
        }
        
    }
}

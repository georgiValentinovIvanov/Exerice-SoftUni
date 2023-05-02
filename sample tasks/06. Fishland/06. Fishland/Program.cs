using System;

namespace _06._Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double macherelPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double bonitoKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            double midiKg = double.Parse(Console.ReadLine());

            double bonitoPrice = (macherelPrice + (macherelPrice * 0.60));
            double sumBonito = bonitoKg * bonitoPrice;

            double safrid = (cacaPrice  + (cacaPrice * 0.80));
            double sumSafrid = safridKg * safrid;
            double sumMidi = 7.50;
            double midi = midiKg*sumMidi;
            double total =(sumBonito + sumSafrid + midi); 

            Console.WriteLine($"{total:f}");
        }
    }
}

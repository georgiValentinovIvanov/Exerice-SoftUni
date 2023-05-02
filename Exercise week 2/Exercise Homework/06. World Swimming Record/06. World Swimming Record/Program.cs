using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double termMeters = double.Parse(Console.ReadLine());
            double timePerMeteres = double.Parse(Console.ReadLine());

            double delay = Math.Floor(termMeters / 15) * 12.5;

            double recordByIvan = termMeters * timePerMeteres + delay;

            if (recordByIvan < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {recordByIvan:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {recordByIvan - worldRecord:f2} seconds slower.");
            }
        }
    }
}

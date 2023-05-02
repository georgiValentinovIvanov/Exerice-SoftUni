using System;

namespace _03._Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xLoze = int.Parse(Console.ReadLine());
            double yGrapes = double.Parse(Console.ReadLine());
            int zlittersVine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalGrapes = xLoze * yGrapes;
            double vine = 0.40 * totalGrapes / 2.5;
            double remainder = (vine - zlittersVine);
            double lack = zlittersVine - vine;
            double perPerson = remainder / workers;
            if (vine >= zlittersVine)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(vine)} liters.");

                Console.WriteLine($"{Math.Ceiling(remainder)} liters left -> {Math.Ceiling(perPerson)} liters per person. ");
            }
            else if (vine<zlittersVine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(lack)} liters wine needed.");
                
            }
        }
    }
}

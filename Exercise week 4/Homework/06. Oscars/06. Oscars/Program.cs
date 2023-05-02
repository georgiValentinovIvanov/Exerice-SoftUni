using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameActor = Console.ReadLine();
            double pointsAcademy = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string assessorName;
            double assessorPoints;
            
            for (int i = 1; i <= n; i++)
            {
                assessorName = Console.ReadLine();
                assessorPoints = double.Parse(Console.ReadLine());

                pointsAcademy += (assessorName.Length * assessorPoints / 2);
                if (pointsAcademy>=1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {pointsAcademy:f1}!");
                    break; 
                }
            }
            if (pointsAcademy<1250.5)
            {
                Console.WriteLine($"Sorry, {nameActor} you need {1250.5-pointsAcademy:f1} more!");
            }
        }
    }
}

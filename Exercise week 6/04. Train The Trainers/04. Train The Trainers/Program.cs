using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int presentationCount = 0;
            double presentationEv;
            double presentationAvg = 0;

            while (input != "Finish")
            {
                presentationEv = 0;
                for (int i = 1; i <=n; i++)
                {
                    presentationEv += double.Parse(Console.ReadLine());
                }
                presentationEv /= n;
                Console.WriteLine($"{input} - {presentationEv:f2}.");
                presentationAvg += presentationEv;
                presentationCount++;
                input = Console.ReadLine();
            }
            presentationAvg /= presentationCount;
            Console.WriteLine($"Student's final assessment is {presentationAvg:f2}.");

        }
    }
}

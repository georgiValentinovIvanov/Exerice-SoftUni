using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floorsCount = int.Parse(Console.ReadLine());
            int apartamentsCount = int.Parse(Console.ReadLine());

            for (int fl = floorsCount; fl >=1; fl--)
            {
                for (int apart = 0; apart < apartamentsCount; apart++)
                {
                    if (fl == floorsCount)
                    {
                        Console.Write($"L{fl}{apart} ");
                    }
                    else if (fl%2==0)
                    {
                        Console.Write($"O{fl}{apart} ");
                    }
                    else if (fl%2 != 0)
                    {
                        Console.Write($"A{fl}{apart} ");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}

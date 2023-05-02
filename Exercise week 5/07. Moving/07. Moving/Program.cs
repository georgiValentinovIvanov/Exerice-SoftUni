using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double sum = w * l * h;
            string input = Console.ReadLine();
            

            while (input != "Done")
            {
                double currNum = double.Parse(input);
                sum -= currNum;
                

                if (sum<0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(sum)} Cubic meters more.");
                    return;
                }
                input = Console.ReadLine();
                
            }
            
            
                Console.WriteLine($"{sum} Cubic meters left.");
            
            
        }
    }
}

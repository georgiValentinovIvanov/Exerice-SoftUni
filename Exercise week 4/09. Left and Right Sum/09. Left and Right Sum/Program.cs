using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int nLeft = 0;
            int nRight = 0;


            for (int i = 1; i <= n; i++)
            {
                nLeft = nLeft + int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= n; i++)
            {
                nRight = nRight + int.Parse(Console.ReadLine());
            }

                if (nLeft==nRight)
                {
                    Console.WriteLine($"Yes, sum = {nLeft}");
                }
                else
                {
                int diff = Math.Abs(nRight - nLeft);
                    Console.WriteLine($"No, diff = {diff}");
                }
            
            
        }
    }
}

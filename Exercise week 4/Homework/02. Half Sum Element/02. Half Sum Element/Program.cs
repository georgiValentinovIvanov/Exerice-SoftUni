using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            int num;
            for (int i = 0; i < n; i++)
            {
               num = int.Parse(Console.ReadLine());
                sum = sum + num;
                if (num>max)
                {
                    max = num;
                }
            }
            sum = sum - max;
            if (max==sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = " + max);

            }
            else
            {
                int diff = Math.Abs(max - sum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = " + diff);
            }
        }
    }
}

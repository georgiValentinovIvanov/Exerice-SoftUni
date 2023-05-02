using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;

            while(numbers>sum)
            {
                int currNum = int.Parse(Console.ReadLine());
                sum += currNum;
            }
            Console.WriteLine(sum);
        }
    }
}

using System;
using System.Runtime.Intrinsics.Arm;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int nonPrimeSum = 0;

            string input = Console.ReadLine();
            int currentNum;

            while (input != "stop")
            {
                currentNum = int.Parse(input);

                if (currentNum<0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                bool flag = true;
                for (int i = 2; i < currentNum; i++)
                {
                    if (currentNum%i==0)
                    {
                        flag = false;
                        break;
                    }    
                }
                if (flag)
                {
                    primeSum += currentNum;
                }
                else
                {
                    nonPrimeSum += currentNum;
                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}

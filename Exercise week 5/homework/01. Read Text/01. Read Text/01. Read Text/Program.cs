using System;
using System.Diagnostics;
using System.Threading;

namespace _01._Read_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "Stop")
            {
                Console.WriteLine(input);

            }
        }
    }
}

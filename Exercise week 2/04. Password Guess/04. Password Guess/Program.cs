using System;

namespace _02._Greater_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string b = "s3cr3t!P@ssw0rd";

            if (password == b)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }

        }
    }
}
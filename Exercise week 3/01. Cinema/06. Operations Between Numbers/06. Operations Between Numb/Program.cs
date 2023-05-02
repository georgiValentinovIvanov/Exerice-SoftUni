using System;

namespace _06._Operations_Between_Numb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            

            if (operation == '+' || operation=='-' || operation == '*')
            {
                int result = 0;
                string evenOrOdd = "even";
              if(operation == '+')
                {
                    result = num1 + num2;
                }
              else if (operation == '-')
                {
                    result = num1 - num2;
                }
              else
                {
                    result = num1 * num2;
                }
              if (result%2 != 0)
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}" );
            }
            else
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else if (operation== '/')
                {
                    double result = (double)num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result:f2}");
                }
                else
                {
                    Console.WriteLine($"{num1} % {num2} = {num1%num2}");
                }
            }
            
        }
    }
}

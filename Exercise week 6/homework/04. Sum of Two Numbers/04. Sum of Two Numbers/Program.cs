using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int count = 0;
            int firstNum = -1;
            int secondNum = -1;
            bool flag = false;
            for (int n1 = start; n1 <= end; n1++)
            {
                for (int n2 = start; n2 <= end; n2++)
                {
                    count++;
                    if (n1 + n2 == magicNum)
                    {
                        flag = true;
                        firstNum = n1;
                        secondNum = n2;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine($"Combination N:{count} ({firstNum} + {secondNum} = {magicNum})");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }
        }
    }
}

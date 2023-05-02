using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currNum = 1;
            bool flag = false;

            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (currNum>n)
                    {
                        flag = true;
                        break;
                    }
                    Console.Write(currNum + " ");
                    currNum++;
                }
                if (flag)
                {
                    break;
                }
                Console.WriteLine();
            }
            
        }
    }
}

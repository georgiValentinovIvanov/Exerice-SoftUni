using System;

namespace P05_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int meters = int.Parse(Console.ReadLine());
            int count = 1;
            int top1 = 5364;
            int top2 = 8848;
            int currnt = 0;
            

            while (true)
            {

                if (text == "END")
                {
                    break;
                }
                if (text == "Yes")
                {
                    count++;
                }
                if (count == 5)
                {
                    break;
                }
                int hight = int.Parse(Console.ReadLine());
                currnt += hight;
                if (currnt + top1 >= top2)
                {
                    break;
                }
                if (top1 + currnt < top2)
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine($"{top1+currnt}");
                }
                else
                {
                    Console.WriteLine($"Goal reached for {count} days!");
                    
                }
            }
        }

    }
}

﻿using System;

namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int time = first + second + third;

            int min = time / 60; 
            int sec = time % 60;

            if (sec >= 10)
            {
                Console.WriteLine($"{min}:{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:0{sec}");
            }

            
        }
    }
}

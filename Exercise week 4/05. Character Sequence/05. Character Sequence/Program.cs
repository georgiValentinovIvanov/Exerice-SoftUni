﻿using System;

namespace _05._Character_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char currCh = text[i];
                Console.WriteLine(currCh);
            }
        }
    }
}

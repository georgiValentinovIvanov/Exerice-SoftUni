using System;

namespace _06._Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int suma = 0;
            int sume = 0;
            int sumi = 0;
            int sumo = 0;
            int sumu = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    suma++;
                }
                else if (text[i] == 'e')
                {
                    sume += 2;
                }
                else if (text[i]=='i')
                {
                    sumi += 3;
                }
                else if (text[i]=='o')
                {
                    sumo += 4;
                }
                else if (text[i]=='u')
                {
                    sumu += 5;
                }
            }
            int resultSum = suma + sume + sumi + sumo + sumu;
            Console.WriteLine(resultSum);

        }
    }
}

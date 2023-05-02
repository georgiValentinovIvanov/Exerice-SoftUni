using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m1 = 0;
            int m2 = 0;
            int m3 = 0;
            int m4 = 0;
            int m5 = 0; 

            
            for (int i = 1; i <= n; i++)
            {
                int alpinists = int.Parse(Console.ReadLine());
                if (alpinists <= 5)
                {
                    m1 += alpinists;
                    
                }
                else if (alpinists >= 5 && alpinists <= 12)
                {
                    m2 += alpinists;
                }
                else if (alpinists >= 13 && alpinists <= 25)
                {
                    m3 += alpinists;
                }
                else if (alpinists >= 26 && alpinists <= 40)
                {
                    m4 += alpinists;

                }
                else if (alpinists >= 41)
                {
                    m5 += alpinists;
                }

            }
            double allAlpinists = m1 + m2 + m3 + m4 + m5;
            double presentm1 = m1 / allAlpinists * 100;
            double presentm2 = m2 / allAlpinists * 100;
            double presentm3 = m3 / allAlpinists * 100;
            double presentm4 = m4 / allAlpinists * 100;
            double presentm5 = m5 / allAlpinists * 100;

            Console.WriteLine($"{presentm1:f2}%");
            Console.WriteLine($"{presentm2:f2}%");
            Console.WriteLine($"{presentm3:f2}%");
            Console.WriteLine($"{presentm4:f2}%");
            Console.WriteLine($"{presentm5:f2}%");
            

        }
    }
}

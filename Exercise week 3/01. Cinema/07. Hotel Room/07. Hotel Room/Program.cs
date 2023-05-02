using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int night = int.Parse(Console.ReadLine());
            
            double studioPrice = 0;
            double apartmentPrice = 0;

            if (mounth == "May" || mounth == "October")
            {
                studioPrice =night* 50;
                apartmentPrice = night * 65;
                
                if (night>14)
                {
                    studioPrice -=studioPrice * 0.3;
                    apartmentPrice -= apartmentPrice * 0.1;
                }
                else if (night>7)
                {
                    studioPrice -= studioPrice * 0.05;
                }
            }
            else if(mounth=="June" || mounth=="September")
            {
                studioPrice = night * 75.20;
                apartmentPrice = night * 68.70;

                if (night > 14)
                {
                    studioPrice -= studioPrice * 0.20;
                    apartmentPrice -= apartmentPrice * 0.10;
                }
            }
            else
            {
                studioPrice = night * 76;
                apartmentPrice = night * 77;
                if (night > 14)
                {
                   
                    apartmentPrice -= apartmentPrice * 0.10;
                }
            }
            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}

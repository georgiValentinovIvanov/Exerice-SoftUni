using System;

namespace P04_
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int students = int.Parse(Console.ReadLine());
            
            double group1 = 0;
            double group2 = 0;
            double group3 = 0;
            double group4 = 0;
            double avg = 0;
            double student=0;
            double input;
            

            for (int i = 1; i <= students; i++)
            {
                input = double.Parse(Console.ReadLine());

                
                if (input>=5.00)
                {
                    group1++;
                    avg += input;
                    student++;
                    
                }
                else if (input >= 4.00 && input <= 4.99)
                {
                    group2++;
                    avg += input;
                    student++;
                    
                }
                else if (input >= 3 && input <= 3.99)
                {
                    group3++;
                    avg += input;
                    student++;
                    
                }
                else if (input<3)
                {
                    group4++;
                    avg += input;
                    student++;
                    
                }
            }
            
            double sum1 = (group1 / students) * 100.00;
            double sum2 = (group2 / students) * 100.00;
            double sum3 = (group3 / students) * 100.00;
            double sum4 = (group4 / students) * 100.00;
            avg = (avg / student);
            
            
            Console.WriteLine($"Top students: {sum1:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {sum2:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {sum3:f2}%");
            Console.WriteLine($"Fail: {sum4:f2}%");
            Console.WriteLine($"Average: {avg:f2}");



        }
    }
}

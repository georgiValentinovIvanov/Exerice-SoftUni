using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int badGradeNum = 0;
            double totalGradeNum = 0;
            int grade = 1;
            while(grade<=12)
            {
                
                double gradeNum = double.Parse(Console.ReadLine());
                totalGradeNum += gradeNum;
                if (gradeNum<4)
                {
                    badGradeNum++;  
                    if (badGradeNum>1)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        return;
                    }
                }
                else
                {
                    grade++;
                }
            }
            double averageGrade = totalGradeNum / (12 + badGradeNum);
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
    }
}

using System;
using System.Transactions;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nTurnirs = int.Parse(Console.ReadLine());
            int firstPoints = int.Parse(Console.ReadLine());
            
            
            double pointsW = 0;
            double pointsF = 0;
            double pointsSF = 0;
            double winPoints = 0;


            for (int i = 1; i <= nTurnirs; i++)
            {
                string turnir = Console.ReadLine();

                if (turnir == "W")
                {
                    pointsW += 2000;
                    winPoints++;
                }

                else if (turnir == "F")
                {
                    pointsF += 1200;
                }
                else if (turnir == "SF")
                {
                    pointsSF += 720;
                    
                }
            }
                double precentWins = winPoints / nTurnirs * 100;
                double sumFromTurnir = pointsW + pointsF + pointsSF;
                double finalPoints = pointsW + pointsF + pointsSF + firstPoints;
                

                Console.WriteLine($"Final points: {finalPoints}");
                Console.WriteLine($"Average points: {Math.Floor(sumFromTurnir/nTurnirs)}");
                Console.WriteLine($"{precentWins:f2}%");
            
        }
    }
}

using System;

namespace _05._Movie_Ratings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            string maxRatingMovieName = string.Empty;
            double maxRating = double.MinValue;
            
            string minRatingMovieName = string.Empty;
            double minRating = double.MaxValue;

            double totalRating = 0;
            for (int i = 1; i <= n; i++)
            {
                string movieName = Console.ReadLine();
                double movieRating = double.Parse(Console.ReadLine());

                if (movieRating > maxRating)
                {
                    maxRatingMovieName = movieName;
                    maxRating = movieRating;
                }
                if (movieRating < minRating)
                {
                    minRatingMovieName = movieName;
                    minRating = movieRating;

                }

                totalRating += movieRating;
            }
            double averigeRating = totalRating / n;

                Console.WriteLine($"{maxRatingMovieName} is with highest rating: {maxRating:f1}");
                Console.WriteLine($"{minRatingMovieName} is with lowest rating: {minRating:f1}");
                Console.WriteLine($"Average rating: {averigeRating:f1}");
            
        }
    }
}

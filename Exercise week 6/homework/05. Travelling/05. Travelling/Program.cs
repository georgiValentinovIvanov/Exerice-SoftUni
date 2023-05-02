using System;

class Program
{
    static void Main()
    {
        string destination = string.Empty;
        double moneyNeeded = 0;
        string savings = string.Empty; // Тук го правим string
        double money = 0;

        while (true)
        {
            destination = Console.ReadLine();
            if (destination == "End")
            {
                break;
            }

            moneyNeeded = double.Parse(Console.ReadLine());
            //savings = 0;
            money = 0;

            while (money < moneyNeeded)
            {
                savings = Console.ReadLine();

                if (savings == "End")
                {
                    return; // Приключваме програмата, ако е "End"
                }

                money += double.Parse(savings); // Парсваме savings понеже в началото на програмата е string

                if (money >= moneyNeeded)
                {
                    Console.WriteLine($"Going to {destination}!");
                }
            }
        }
    }
}
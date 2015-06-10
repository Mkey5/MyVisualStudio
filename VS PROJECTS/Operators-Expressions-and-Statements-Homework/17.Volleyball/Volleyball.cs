using System;

    class Volleyball
    {
        static void Main()
        {
            string leap = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int homeTown = int.Parse(Console.ReadLine());
            int weekendsInAYear = 48;
            double daysPlayed = 0;

            double normalWeekends = weekendsInAYear - homeTown;
            normalWeekends = normalWeekends * 3.0 / 4.0;
            daysPlayed = daysPlayed + normalWeekends + homeTown;
            daysPlayed = daysPlayed + (holidays * (2.0 / 3.0));

            if (leap=="leap")
            {
                daysPlayed = Math.Floor(daysPlayed * 1.15);
            }
            Console.WriteLine(Math.Floor(daysPlayed));
        }
    }

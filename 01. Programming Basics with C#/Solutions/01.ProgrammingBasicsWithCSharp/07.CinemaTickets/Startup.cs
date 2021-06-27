namespace _07.CinemaTickets
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var student = 0d;
            var standard = 0d;
            var kids = 0d;
            var totalTickets = 0d;

            var movieName = Console.ReadLine();

            while (movieName != "Finish")
            {
                var totalSeats = double.Parse(Console.ReadLine());
                var freeSeats = totalSeats;
                var ticketType = Console.ReadLine();

                while (ticketType != "End" && freeSeats > 0)
                {
                    switch (ticketType)
                    {
                        case "student":
                            freeSeats--;
                            student++;
                            totalTickets++;
                            break;
                        case "standard":
                            freeSeats--;
                            standard++;
                            totalTickets++;
                            break;
                        case "kid":
                            freeSeats--;
                            kids++;
                            totalTickets++;
                            break;
                    }

                    if (freeSeats > 0)
                    {
                        ticketType = Console.ReadLine();
                    }
                }

                double percentOfFull = (totalSeats - freeSeats) / totalSeats * 100;
                Console.WriteLine($"{movieName} - {Math.Round(percentOfFull, 2)}% full.");

                movieName = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTickets}");

            double percentOfStudentTickets = (100 * student) / totalTickets;
            double percentOfStandardTickets = (100 * standard) / totalTickets;
            double percentOfKidsTickets = (100 * kids) / totalTickets;

            Console.WriteLine($"{percentOfStudentTickets:f2}% student tickets.");
            Console.WriteLine($"{percentOfStandardTickets:f2}% standard tickets.");
            Console.WriteLine($"{percentOfKidsTickets:f2}% kids tickets.");
        }
    }
}

﻿namespace _04.CenturiesToMinutes
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;

            int days = (int) (years * 365.2422);

            int hours = days * 24;

            int minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
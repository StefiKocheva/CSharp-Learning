namespace ExplicitInterfaces
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            List<Citizen> citizens = new List<Citizen>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                var personInfo = command.Split(" ");

                Citizen citizen = new Citizen();
                citizens.Add(citizen);

                citizen.Name = personInfo[0];
                citizen.Country = personInfo[1];
                citizen.Age = personInfo[2];

                command = Console.ReadLine();
            }

            foreach (var citizen in citizens)
            {
                Console.WriteLine(citizen.GetName());
                Console.WriteLine((citizen as IResident)?.GetName());
            }
        }
    }
}

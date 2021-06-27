namespace AdvancedOperationsInSet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            HashSet<Person> people = new HashSet<Person>(
                new List<Person> 
                {
                    new Person("Stefani", "Kocheva", 15),
                    new Person("Nikolay", "Stoyanov", 15),
                    new Person("Nikolay", "Stoynov", 15),
                    new Person("Nenka", "Nikolova", 48),
                    new Person("Krasimira", "Krasteva", 45),
                });

            people.RemoveWhere(p => p.Age < 18); // Remove those elements that have a match in the where clause.

            Console.WriteLine(people.Any(p => p.FirstName == "Stefani")); // true -> Finds out there is or not an element for the condition.

            Person person = people.FirstOrDefault(p => p.FirstName == "Nikolay"); // Returns the unique element with first name Nikolay.
            // { FirstName: "Nikolay"; LastName: "Stoyanov"; Age: 15}

            people.OrderBy(p => p.Age);
        }
    }
}

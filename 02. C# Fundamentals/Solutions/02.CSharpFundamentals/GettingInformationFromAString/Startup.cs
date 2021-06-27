namespace GettingInformationFromAString
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            //String manipulation
            string fullName = Console.ReadLine(); //Read a string with at least one separator.

            string[] names = fullName.Split().ToArray();
            //.Split() - Split the readed string by the separator (by default it splits by a space).
            //.ToArray() - Turns the splitted content into an array.

            string firstName = names[0]; //Set the value of firstName
            string lastName = names[1]; //Set the value of lastName

            Console.WriteLine($"First name: {firstName}"); //Print the value of firstName
            Console.WriteLine($"Last name: {lastName}"); //Print the value of lastName

            //Numbers manipulation

            string input = Console.ReadLine(); //Read a string with at least one separator.

            int[] numbers = input.Split("; ").Select(int.Parse).ToArray();
            //.Split() - Split the readed string by the separator (by default it splits by a space).
            //.Select() - Converts the type of the elements of the array. (Always string to double, for example).
            //.ToArray() - Turns the splitted content into an array.

            Console.WriteLine(numbers.Sum()); //Print the sum of array's elements thanks to Linq library.
        }
    }
}

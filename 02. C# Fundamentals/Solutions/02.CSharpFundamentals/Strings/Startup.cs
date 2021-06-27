namespace Strings
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string firstname = "Stefani"; // Declare by the keyword string.

            char thirdCharacter = firstname[2]; // Has positions of type char.

            Console.WriteLine(thirdCharacter);

            // Cannot do this -> name[2] = 'a';.
            // String is read-only.

            char[] nameCharacters = firstname.ToCharArray(); // Makes a new char[] where the position of a character in the array is the same as this in the string.

            // Concatenation
            string lastName = "Kocheva";

            // First way
            string fullName = firstname + " " + lastName;

            // Second way
            string concatenatedFullName = string.Concat(firstname, " ", lastName);

            // Searching
            string fruits = "banana, apple, kiwi, banana, apple";

            // Returns the first match index.
            Console.WriteLine(fruits.IndexOf("banana"));

            // Returns the last match index.
            Console.WriteLine(fruits.LastIndexOf("banana"));

            //If it didn't find a match, it returns -1.

            // Returns if it cotains the given string or not.
            Console.WriteLine(fruits.Contains("banana")); // true or false

            // Substring
            string name = "Nikolay Stoyanov";

            string substringedFirstName = name.Substring(0, 6); // Returns "Nikolay".

            string substringedLastName = name.Substring(8); // Returns "Stoyanov".
        }
    }
}

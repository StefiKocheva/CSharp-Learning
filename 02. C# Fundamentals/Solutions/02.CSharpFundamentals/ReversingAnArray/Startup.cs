namespace ReversingAnArray
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            //First way
            char[] characters = new char[4] { 'a', 'b', 'c', 'd' }; //Creating a full array.
            char[] reversedArr = new char[characters.Length]; //Creating an empty array.
            
            for (int i = 0; i <= reversedArr.Length - 1; i++) //Iterating reversedArr.
            {
                reversedArr[i] = characters[characters.Length - 1 - i];
                //Setting the i position of the reversedArr to last but i position of the characters.
            }

            Console.WriteLine(string.Join(" ", reversedArr)); //Printing the reversedArr.

            Console.WriteLine();

            //Second way
            int[] numbers = new int[4] { 1, 2, 3, 4 }; //Creating a new array.

            Array.Reverse(numbers); //Reversing an array with Array.Reverse().

            Console.WriteLine(string.Join(" ", numbers)); //Printing the numbers
        }
    }
}

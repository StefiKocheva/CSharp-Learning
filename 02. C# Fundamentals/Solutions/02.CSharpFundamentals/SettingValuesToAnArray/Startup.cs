namespace SettingValuesToAnArray
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            //--Problem--
            //You have to read the count of numbers(count). (line 14)
            //On the next count lines you should read the numbers. (lines 17 to 19)
            //You have to put the values into the array. (line 21)

            int count = int.Parse(Console.ReadLine()); //Read the count of the numbers.
            int[] numbers = new int[count]; //Create an array named "numbers" with length equals to "count".
            
            for (int i = 0; i < count; i++) //Read "count" numbers from the console and iterating the positions of the array.
            {
                int currentNumber = int.Parse(Console.ReadLine()); //Declaring a new variable from the console.

                numbers[i] = currentNumber; //Setting the i position of the array to "currentNumber".
            }
        }
    }
}

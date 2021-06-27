namespace ForeachLoop
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            //--Problem--
            //You have to read the count of numbers(count). (line 15)
            //On the next count lines you should read the numbers. (lines 18 to 20)
            //You have to put the values into the array. (line 22)
            //Print the values of the array. (lines 27 to 44)
            
            int count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                numbers[i] = currentNumber;
            }

            //We can iterate an array with a loop
            
            //The "for" way
            //Can iterate a part of the array.
            //Can change the values.
            //Can iterate in reverse order.
            for (int i = numbers.Length - 1; i >= 0; i--) //Iterate the loop from zero position to last one.
            {
                Console.WriteLine(numbers[i]); //Print the value on i position of the loop.
            }
            
            //The "foreach" way
            //Can't iterate a part of the array.
            //Can't change the values.
            //Can't iterate in reverse order.
            foreach (int number in numbers)
            {
                //Can't do this: number += 2;
                Console.WriteLine(number);
            }
        }
    }
}

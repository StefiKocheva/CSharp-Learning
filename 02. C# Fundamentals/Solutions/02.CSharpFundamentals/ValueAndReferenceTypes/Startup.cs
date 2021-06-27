namespace ValueAndReferenceTypes
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            //Value types
            int a = 5; //Declaring and storing in the memory value to a variable named a.
            int b = a; //Declaring and storing in the memory value to a variable named b equal to a's one.
            b++; //Increasing by 1 b;

            Console.WriteLine(a); //Printing a;
            Console.WriteLine(b); //Printing b;

            //Reference types
            int[] firstArr = new int[5] { 1, 2, 3, 4, 5 }; //Creating a new array in the memory. Setting a's reference to this place in the memory.
            int[] secondArr = firstArr; //Setting secondArr's reference to firstArr's one.
            secondArr[3] = 6; //Changing the third position's value in the memory where secondArr is referencing to.

            Console.WriteLine(firstArr[3]); //Printing the third position of firstArr.
            Console.WriteLine(secondArr[3]); //Printing the third position of secondArr.
        }
    }
}

namespace ArraysOverview
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            //Creating new array
            int[] array = new int[4/*length*/] { 1, 2, 3 ,4}; //Length required, can't change its length
            
            //Positions
            Console.WriteLine(array[0]); //1
            Console.WriteLine(array[1]); //2
            Console.WriteLine(array[2]); //3
            Console.WriteLine(array[3]); //4

            //Get array's length
            Console.WriteLine(array.Length); //4
        }
    }
}

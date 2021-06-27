namespace _09.GreaterOfTwoValues
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());

                    int greaterNum = GreaterInt(num1, num2);

                    Console.WriteLine(greaterNum);
                    break;
                case "char":
                    char char1 = char.Parse(Console.ReadLine());
                    char char2 = char.Parse(Console.ReadLine());

                    char greaterChar = GreaterChar(char1, char2);

                    Console.WriteLine(greaterChar);
                    break;
                case "string":
                    string string1 = Console.ReadLine();
                    string string2 = Console.ReadLine();

                    string greaterString = GreaterString(string1, string2);

                    Console.WriteLine(greaterString);
                    break;
            }
        }

        private static int GreaterInt(int number1, int number2) 
            => number1 > number2 ? number1 : number2;

        private static char GreaterChar(char char1, char char2) 
            => char1 > char2 ? char1 : char2;

        private static string GreaterString(string string1, string string2)
            => string1.CompareTo(string2) > 0 ? string1 : string2;
    }
}

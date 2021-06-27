namespace _06.SumOfVoyels
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var sumOfVowels = 0;

            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                        sumOfVowels += 1;
                        break;
                    case 'e':
                        sumOfVowels += 2;
                        break;
                    case 'i':
                        sumOfVowels += 3;
                        break;
                    case 'o':
                        sumOfVowels += 4;
                        break;
                    case 'u':
                        sumOfVowels += 5;
                        break;
                }
            }

            Console.WriteLine(sumOfVowels);
        }
    }
}

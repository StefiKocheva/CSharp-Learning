namespace _05.DigitsLettersAndOther
{
    using System;
    using System.Text;

    public static class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string digits = string.Empty;
            string letters = string.Empty;
            string symbols = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char currentCharacter = input[i];

                if (char.IsDigit(currentCharacter))
                {
                    digits += currentCharacter;
                }
                else if (char.IsLetter(currentCharacter))
                {
                    letters += currentCharacter;
                }
                else
                {
                    symbols += currentCharacter;
                }
            }

            var sb = new StringBuilder();

            sb.AppendLine(digits);
            sb.AppendLine(letters);
            sb.AppendLine(symbols);

            Console.WriteLine(sb);
        }
    }
}

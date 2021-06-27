namespace _07.SoftUniParty
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            var number = Console.ReadLine();

            bool isPartyBegan = false;

            while (number != "END")
            {
                while (number != "PARTY")
                {
                    if (isPartyBegan)
                    {
                        break;
                    }

                    _ = char.IsDigit(number[0]) ? vip.Add(number) : regular.Add(number);

                    number = Console.ReadLine();
                }

                isPartyBegan = true;

                _ = char.IsDigit(number[0]) ? vip.Remove(number) : regular.Remove(number);

                number = Console.ReadLine();
            }

            Console.WriteLine(vip.Count + regular.Count);

            foreach (var num in vip)
            {
                Console.WriteLine(num);
            }

            foreach (var num in regular)
            {
                Console.WriteLine(num);
            }
        }
    }
}

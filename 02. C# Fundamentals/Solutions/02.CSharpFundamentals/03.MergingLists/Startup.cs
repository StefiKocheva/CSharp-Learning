namespace _03.MergingLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            List<int> firstList = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < (firstList.Count > secondList.Count ? secondList.Count : firstList.Count); i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                for (int i = secondList.Count; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                }
            }
            else
            {
                for (int i = firstList.Count; i < secondList.Count; i++)
                {
                    result.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

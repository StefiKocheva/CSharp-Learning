namespace CSharpAdvancedExercising
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            var cups = new Queue<int>();
            var filledBottles = new Stack<int>();

            foreach (var cup in Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray())
            {
                cups.Enqueue(cup);
            }

            foreach (var filledBottle in Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray())
            {
                filledBottles.Push(filledBottle);
            }

            int allWaistedLitters = 0;

            while (cups.Count > 0 || filledBottles.Count > 0)
            {
                if (cups.Count > 0 || filledBottles.Count > 0)
                {
                    var currentCup = cups.Peek();
                    var currentBottle = filledBottles.Peek();

                    while (currentCup > 0)
                    {
                        if (currentBottle >= currentCup)
                        {
                            int waistedLittersWater = currentBottle - currentCup;
                            allWaistedLitters += waistedLittersWater;

                            currentCup = 0;

                            cups.Dequeue();
                        }

                        if (currentCup > currentBottle)
                        {
                            while (currentCup != 0)
                            {
                                if (currentBottle >= currentCup)
                                {
                                    int waistedLittersWater1 = currentBottle - currentCup;
                                    allWaistedLitters = currentBottle - currentCup;

                                    if (currentCup <= 0)
                                    {
                                        cups.Dequeue();
                                    }
                                }

                                currentCup -= currentBottle;
                                filledBottles.Pop();
                            }

                            cups.Dequeue();
                        }

                        if (filledBottles.Count > 0)
                        {
                            filledBottles.Pop();
                        }
                    }
                }
            }


            if (cups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                Console.WriteLine($"Waisted litters of water: {allWaistedLitters}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", cups)}");
                Console.WriteLine($"Waisted litters of water: {allWaistedLitters}");
            }
        }
    }
}

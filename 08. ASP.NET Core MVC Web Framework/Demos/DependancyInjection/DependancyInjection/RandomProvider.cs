using System;

namespace DependancyInjection
{
    public class RandomProvider : IRandomProvider
    {
        private static readonly Random Random = new Random();

        public int Number(int min, int max)
            => Random.Next(min, max + 1);
    }
}

namespace _04.RandomList
{
    using System;
    using System.Collections.Generic;

    public class RandomList<T> : List<T>
    {
        private List<T> data;

        public RandomList()
        {
            this.data = new List<T>();
        }
        public T RandomElement()
        {
            var random = new Random();

            var index = random.Next(0, data.Count);

            var element = data[index];

            data.RemoveAt(index);

            return element;
        }

        public void Add(T item)
        {
            this.data.Add(item);
        }
    }
}

namespace EqualityLogic
{
    using System.Collections;
    using System.Collections.Generic;

    public class Numbers : IEnumerable<int>
    {
        private List<int> data;

        public Numbers()
        {
            this.data = new List<int>();
        }

        public void Add(int number)
        {
            this.data.Add(number);
        }

        public void Remove(int number)
        {
            this.data.Remove(number);
        }

        public int Count { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            return new NumbersIterator(this.data);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

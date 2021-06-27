namespace YieldReturn
{
    using System.Collections;
    using System.Collections.Generic;

    public class Numbers : IEnumerable<int> // Inherit the interaface.
    {
        private List<int> data;

        public Numbers()
        {
            this.data = new List<int>();
        }

        public void Add(int num)
        {
            this.data.Add(num);
        }

        public void Remove(int num)
        {
            this.data.Remove(num);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++) // Iterate the elements by foreach
            {
                yield return this.data[i]; // Return the current num, when invoked by the foreach.
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator(); // Invoke the previous method.

        public int Count => this.data.Count;
    }
}

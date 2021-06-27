namespace ReversedForeach
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
        { // Create a new class with the iterating settings.
            return new NumbersIterator(data); // Return a new instance of the custom iterator and pass to it a list. 
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator(); // Invoke the previous method.

        public int Count => this.data.Count;
    }
}

namespace CustomIterators
{
    using System.Collections;
    using System.Collections.Generic;

    public class NumbersIterator : IEnumerator<int> // Inherit the interface
    {
        private List<int> data;
        private int index; // Create an index

        public NumbersIterator(List<int> data)
        {
            this.Reset(); // Invoke Reset method.

            this.data = data;
        }

        public int Current => data[index]; // Returns current element.

        object IEnumerator.Current => throw new System.NotImplementedException();

        public void Dispose()
        { // Should be empty.
        }

        public bool MoveNext()
        {
            this.index++; // Increase the index.

            return this.index < this.data.Count; // Returns if there is a next element.
        }

        public void Reset()
        {
            this.index = -1; // Set the value of the index to -1.
        }
    }
}
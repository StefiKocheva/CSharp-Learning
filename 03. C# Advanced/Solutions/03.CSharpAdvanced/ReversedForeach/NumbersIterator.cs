namespace ReversedForeach
{
    using System.Collections;
    using System.Collections.Generic;

    public class NumbersIterator : IEnumerator<int> // Inherit the interface
    {
        private List<int> data;
        private int index; // Create an index

        public NumbersIterator(List<int> data)
        {
            this.data = data;

            this.Reset(); // Invoke Reset method.
        }

        public int Current => data[index]; // Returns current element.

        object IEnumerator.Current => throw new System.NotImplementedException();

        public void Dispose()
        { // Should be empty.
        }

        public bool MoveNext()
        {
            this.index--; // Decrease the index.

            return this.index >= 0; // Returns if there is a next element.
        }

        public void Reset()
        {
            this.index = this.data.Count; // Set the value of the index to the count of the elements.
        }
    }
}
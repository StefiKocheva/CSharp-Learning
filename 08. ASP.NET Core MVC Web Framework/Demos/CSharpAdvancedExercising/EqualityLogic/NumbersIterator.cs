namespace EqualityLogic
{
    using System.Collections;
    using System.Collections.Generic;

    public class NumbersIterator : IEnumerator<int>
    {
        private int index;
        private List<int> data;

        public NumbersIterator(List<int> data)
        {
            this.Reset();

            this.data = data;
        }

        public int Current => this.data[index];

        object IEnumerator.Current => throw new System.NotImplementedException();

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public bool MoveNext()
        {
            this.index++;

            return this.index < this.data.Count;
        }

        public void Reset()
        {
            this.index = -1;
        }
    }
}
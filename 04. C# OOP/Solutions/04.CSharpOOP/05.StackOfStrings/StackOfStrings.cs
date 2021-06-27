namespace _05.StackOfStrings
{
    using System.Collections.Generic;

    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty() => this.Count == 0;

        public void AddRange(string[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                this.Push(data[i]);
            }
        }
    }
}

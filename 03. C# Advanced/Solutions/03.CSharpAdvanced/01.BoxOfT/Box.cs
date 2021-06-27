namespace _01.BoxOfT
{
    using System.Collections.Generic;

    public class Box<T>
    {
        public Box()
        {
            this.elements = new Stack<T>();
        }

        private Stack<T> elements;

        public void Add(T element)
        {
           elements.Push(element);
        }

        public T Remove()
        {
            return this.elements.Pop();
        }

        public int Count => this.elements.Count;
    }
}

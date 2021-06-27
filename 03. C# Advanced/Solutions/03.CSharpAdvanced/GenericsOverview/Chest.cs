using System.Collections.Generic;

namespace GenericsOverview
{
    public class Chest<T> // Add T to make it generic class
        where T : class // Add restrictions
    {
        public Chest()
        {
            this.Items = new List<T>();
        }

        public int Count => this.Items.Count;

        public string Color { get; set; }

        public List<T> Items { get; set; } // Generic collection

        public void Add(T item) // Generic method - accepts T item
        {
            this.Items.Add(item);

        }

        public void Remove(T item)
        {
            this.Items.Remove(item);
        }
    }
}

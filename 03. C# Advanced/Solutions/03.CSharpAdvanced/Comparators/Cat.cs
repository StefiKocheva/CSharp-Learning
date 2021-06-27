namespace Comparators
{
    using System;

    public class Cat : IComparable<Cat> // Inherit the interface
    {
        public Cat(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public int Age { get; set; }

        public int CompareTo(Cat other)
        {
            return this.Name.CompareTo(other.Name); // Return the result of comparing.
        }
    }
}

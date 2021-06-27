namespace CreatingClassesUsingConstructors
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Cat
    {
        // constructor
        public Cat(string name, int age) // Has the same name as the class
        {
            this.Name = name;
            this.Age = age;
        }

        public Cat(string name, int age, string color) 
            : this(name, age)
        {
            this.Color = color;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Color { get; set; }

        public Owner Owner { get; set; }
    }
}

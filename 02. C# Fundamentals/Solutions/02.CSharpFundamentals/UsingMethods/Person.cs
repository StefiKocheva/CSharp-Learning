namespace UsingMethods
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString() // Override - to change the default logic
        {
            return $"I'm {this.Name} and I am {this.Age} yo.";
        }
    }
}

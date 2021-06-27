namespace Queues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Person
    {
        public Person(string name, int age, string nationality)
        {
            this.Name = name;
            this.Age = age;
            this.Nationality = nationality;
        }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Nationality { get; set; }
    }
}

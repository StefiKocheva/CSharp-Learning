namespace CreatingClassesUsingConstructors
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Owner
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public List<Cat> Cats { get; set; }
    }
}

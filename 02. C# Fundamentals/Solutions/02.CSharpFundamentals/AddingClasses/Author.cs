namespace AddingClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Author
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public List<Book> Books { get; set; }
    }
}

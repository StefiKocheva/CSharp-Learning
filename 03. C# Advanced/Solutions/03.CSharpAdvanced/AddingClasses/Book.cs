namespace AddingClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Book
    {
        //field
        private string bookPrivateId; // Fields should be always private. End with a semicolon.

        //property
        public string Title { get; set; } // Property should be always public.

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }

        public Author Author { get; set; }
    }
}

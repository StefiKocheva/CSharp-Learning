namespace AddingClasses
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            Author author = new Author()
            {
                FirstName = "Stephie",
                LastName = "Kocheva",
                Age = 15,
            };

            Book book = new Book()
            {
                Title = "The little prince",
                Description = "Kinda interesting book",
                Count = 100000,
                Price = 21,
                Author = author,
            };

            author.Books.Add(book);

            Console.WriteLine(book.Author.Age);
        }
    }
}

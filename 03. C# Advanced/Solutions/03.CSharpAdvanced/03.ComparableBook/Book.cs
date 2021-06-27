namespace _03.ComparableBook
{
    using System;
    using System.Collections.Generic;

    public class Book : IComparable<Book>
    {

        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = new List<string>(authors);
        }

        public string Title { get; set; }

        public int Year { get; set; }

        public List<string> Authors { get; set; }

        public int CompareTo(Book other)
        {
            var years = this.Year.CompareTo(other.Year);

            if (years == 0)
            {
                years = this.Title.CompareTo(other.Title);
            }

            return years;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}

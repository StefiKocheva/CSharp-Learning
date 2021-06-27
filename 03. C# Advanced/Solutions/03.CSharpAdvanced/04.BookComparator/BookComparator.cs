namespace _04.BookComparator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book first, Book second)
        {
            var years = first.Title.CompareTo(second.Title);

            if (years == 0)
            {
                years = second.Year.CompareTo(first.Year);
            }

            return years;
        }
    }
}

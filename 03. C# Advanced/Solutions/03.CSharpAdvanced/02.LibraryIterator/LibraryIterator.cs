namespace _02.LibraryIterator
{
    using System.Collections;
    using System.Collections.Generic;

    public class LibraryIterator : IEnumerator<Book>
    {
        private List<Book> books;
        private int index;

        public LibraryIterator(List<Book> books)
        {
            this.Reset();

            this.books = books;
        }

        public Book Current => books[index];

        object IEnumerator.Current => throw new System.NotImplementedException();

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            this.index++;

            return this.index < this.books.Count;
        }

        public void Reset()
        {
            this.index = -1;
        }
    }
}

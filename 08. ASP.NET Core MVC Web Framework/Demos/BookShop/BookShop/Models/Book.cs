namespace BookShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using BookShop.Models.Enums;

    public class Book
    {
        public Book()
        {
            this.BookCategories = new HashSet<BookCategory>();
        }

        [Key]
        public int BookId { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int Copies { get; set; }

        public decimal Price { get; set; }

        public EditionTypes EditionType { get; set; }

        public AgeRestrictions AgeRestriction { get; set; }

        public Author Author { get; set; }

        public int AuthorId { get; set; }

        public ICollection<BookCategory> BookCategories { get; set; }
    }
}

namespace BookShop
{
    using BookShop.Data;
    using System.Linq;
    using System.Text;

    public static class StartUp
    {
        public static void Main()
        {
            
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var sb = new StringBuilder();

            context
                .Books
                .OrderBy(b => b.Title)
                .Where(b => b.AgeRestriction.ToString().ToLower() == command.ToLower())
                .Select(b => new
                {
                    b.Title,
                })
                .ToList()
                .ForEach(b => sb.AppendLine(b.Title));

            return sb.ToString().TrimEnd();
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var sb = new StringBuilder();

            context
                .Books
                .OrderBy(b => b.BookId)
                .Where(b => b.Copies < 5000)
                .Select(b => new
                {
                    b.Title,
                })
                .ToList()
                .ForEach(b => sb.AppendLine(b.Title));

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var sb = new StringBuilder();

            context
                .Books
                .OrderByDescending(b => b.Price)
                .Where(b => b.Price > 40)
                .Select(b => new
                {
                    b.Title,
                    b.Price,
                })
                .ToList()
                .ForEach(b => sb.AppendLine($"{b.Title} - ${b.Price}"));

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var sb = new StringBuilder();

            context
                .Books
                .OrderBy(b => b.BookId)
                .Where(b => b.ReleaseDate.Value.Year != year)
                .Select(b => new
                {
                    b.Title
                })
                .ToList()
                .ForEach(b => sb.AppendLine(b.Title));

             return sb.ToString().TrimEnd();
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            //context
            //    .Categories
                

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var sb = new StringBuilder();

            var books = context
                .Books
                .OrderBy(b => b.BookCategories)
                .ThenByDescending(b => b.ReleaseDate)
                .Take(3)
                .Select(b => new
                {
                    Category = b.BookCategories.Select(bc => new
                    {
                        Name = bc.Category.Name,
                    }),
                    b.Title,
                    ReleaseYear = b.ReleaseDate.Value.Year
                })
                .ToList();

            foreach (var b in books)
            {
                foreach (var c in b.Category)
                {
                    sb.AppendLine($"--{c.Name}");
                }

                sb.AppendLine($"{b.Title} ({b.ReleaseYear})");
            }

            return sb.ToString().TrimEnd();
        }

        public static void IncreasePrices(BookShopContext context)
        {
            context
                .Books
                .Where(b => b.ReleaseDate.Value.Year < 2010)
                .ToList()
                .ForEach(b => b.Price *= 0.5m);

            context.SaveChanges();
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var count = context
                .Books
                .Where(b => b.Copies < 4200)
                .Count();

            context
                .Books
                .Where(b => b.Copies < 4200)
                .ToList()
                .ForEach(b => context.Remove(b));

            context.SaveChanges();

            return count;
        }
    }
}

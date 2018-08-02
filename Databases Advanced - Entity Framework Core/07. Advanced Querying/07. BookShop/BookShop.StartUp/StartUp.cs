namespace BookShop
{
    using BookShop.Data;
    using BookShop.Initializer;
    using BookShop.Models;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            //int input = int.Parse(Console.ReadLine());
            //string input = Console.ReadLine();

            using (var db = new BookShopContext())
            {
                //DbInitializer.ResetDatabase(db); Creates 'BookShop' Database and Seeds data in it.

                int result = RemoveBooks(db);

                Console.WriteLine($"{result} books were deleted");
            }
        }

        // Problem 1.	Age Restriction
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            int enumValue = -1;

            switch (command.ToLower())
            {
                case "minor":
                    enumValue = 0;
                    break;
                case "teen":
                    enumValue = 1;
                    break;
                case "adult":
                    enumValue = 2;
                    break;
            }

            string[] titles = context.Books
                .Where(b => b.AgeRestriction == (AgeRestriction)enumValue)
                .Select(b => b.Title)
                .OrderBy(t => t)
                .ToArray();

            string result = String.Join(Environment.NewLine, titles);

            return result;
        }

        // Problem 2.	Golden Books
        public static string GetGoldenBooks(BookShopContext context)
        {
            var sb = new StringBuilder();

            context
                .Books
                .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList()
                .ForEach(t => sb.AppendLine(t));

            return sb.ToString();
        }

        // Problem 3.   Books by Price
        public static string GetBooksByPrice(BookShopContext context)
        {
            var sb = new StringBuilder();

            context.Books
                .Where(b => b.Price > 40)
                .Select(b => new
                {
                    b.Title,
                    b.Price
                })
                .OrderByDescending(b => b.Price)
                .ToList()
                .ForEach(o => sb.AppendLine($"{o.Title} - ${o.Price:f2}"));

            return sb.ToString();
        }

        // Problem 4.   Not Released In
        public static string GetBooksNotRealeasedIn(BookShopContext context, int year)
        {
            string[] titles = context.Books
                .Where(b => b.ReleaseDate.Value.Year != year)
                .OrderBy(t => t.BookId)
                .Select(b => b.Title)
                .ToArray();

            string result = String.Join(Environment.NewLine, titles);

            return result;
        }

        // Problem 5.   Book Titles by Category
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] categories = input.ToLower().Split(new [] { "\t", " ", Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries);

            string[] titles = context.Books
                .Where(b => b.BookCategories.Any(c => categories.Contains(c.Category.Name.ToLower())))
                .Select(b => b.Title)
                .OrderBy(t => t)
                .ToArray();

            string result = String.Join(Environment.NewLine, titles);

            return result;
        }

        // Problem 6.  Released Before Date
        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var sb = new StringBuilder();

            context.Books
                .Where(b => b.ReleaseDate < DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture)) // DateTime.Parse(date, CultureInfo.InvariantCulture)
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => new
                {
                    b.Title,
                    b.EditionType,
                    b.Price
                })
                .ToList()
                .ForEach(a => sb.AppendLine($"{a.Title} - {a.EditionType} - ${a.Price:f2}"));

            return sb.ToString();
        }

        // Problem 7.  Author Search
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            context.Authors
                .Where(a => a.FirstName != null && a.FirstName.EndsWith(input))
                .Select(a => a.FirstName == null ? a.LastName : $"{a.FirstName} {a.LastName}")
                .OrderBy(n => n)
                .ToList()
                .ForEach(a => sb.AppendLine(a));

            return sb.ToString();
        }

        // Problem 8.  Book Search
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToList()
                .ForEach(b => sb.AppendLine(b));

            return sb.ToString();
        }

        // Problem 9.  Book Search by Author
        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var sb = new StringBuilder();

            context.Books
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .OrderBy(b => b.BookId)
                .Select(b => new
                {
                    b.Title,
                    AuthorFullName = $"{b.Author.FirstName} {b.Author.LastName}"
                })
                .ToList()
                .ForEach(a => sb.AppendLine($"{a.Title} ({a.AuthorFullName})"));

            return sb.ToString();
        }

        // Problem 10.  Count Books
        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var booksCounts = context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .Count();

            return booksCounts;
        }

        // Problem 11.  Total Book Copies
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var sb = new StringBuilder();

            context.Authors
                .Select(b => new
                {
                    AuthorFullName = $"{b.FirstName} {b.LastName}",
                    TotalBookCopies = b.Books
                        .Select(c => c.Copies)
                        .Sum()
                })
                .OrderByDescending(b => b.TotalBookCopies)
                .ToList()
                .ForEach(a => sb.AppendLine($"{a.AuthorFullName} - {a.TotalBookCopies}"));

            return sb.ToString();
        }

        // Problem 12.  Profit by Category
        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var sb = new StringBuilder();

            context.Categories
                .Select(b => new
                {
                    b.Name,
                    TotalProfit = b.CategoryBooks
                        .Select(cb => cb.Book.Copies * cb.Book.Price)
                        .Sum()
                })
                .OrderByDescending(b => b.TotalProfit)
                .ThenBy(b => b.Name)
                .ToList()
                .ForEach(a => sb.AppendLine($"{a.Name} ${a.TotalProfit:f2}"));

            return sb.ToString();
        }

        // Problem 13.  Most RecentBooks
        public static string GetMostRecentBooks(BookShopContext context)
        
            => "--" + string.Join($"{Environment.NewLine}--", context.Categories
                .Select(c => new
                {
                    Name = c.Name,
                    BookCount = c.CategoryBooks
                        .Select(cb => cb.Book)
                        .Count(),
                    TopThreeString = string.Join(Environment.NewLine, c.CategoryBooks
                        .Select(cb => cb.Book)
                        .OrderByDescending(b => b.ReleaseDate)
                        .Take(3)
                        .Select(b => b.ReleaseDate == null
                            ? $"{b.Title} ()"
                            : $"{b.Title} ({b.ReleaseDate.Value.Year})"))
                })
                // .OrderBy(c => c.BookCount) // Wrong Requirement - Judge wants sorting by Name
                .OrderBy(c => c.Name)
                .Select(c => $"{c.Name}{Environment.NewLine}{c.TopThreeString}"));
        

        // Problem 14.  Increase Prices
        public static void IncreasePrices(BookShopContext context)
        {
            context.Books
                .Where(b => b.ReleaseDate.Value.Year < 2010)
                .ToList()
                .ForEach(b => b.Price += 5);

            context.SaveChanges();
        }

        // Problem 15.  Increase Prices
        public static int RemoveBooks(BookShopContext context)
        {
            var booksToRemove = context.Books
                .Where(b => b.Copies < 4200)
                .ToArray();

            int countOfRemovedBooks = booksToRemove.Length;

            context.Books.RemoveRange(booksToRemove);

            context.SaveChanges();

            return countOfRemovedBooks;
        }
    }
}

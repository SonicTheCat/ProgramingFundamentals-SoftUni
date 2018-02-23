namespace _06.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                books.Add(ReadAllBooks());
            }
            Library allBooksIn = new Library();
            allBooksIn.Books = books;

            var dictOfBooks = AddReleaseDateAndTitles(allBooksIn);
            foreach (var pair in dictOfBooks.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                var dateToString = pair.Key.ToString();
                Console.WriteLine("{0} -> {1:dd.MM.yyyy}", pair.Key, pair.Value);
            }
        }

        static Dictionary<string, DateTime> AddReleaseDateAndTitles(Library allBooksIn)
        {
            DateTime printAfterDate = DateTime
           .ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo
           .InvariantCulture);

            var dictOfBooks = new Dictionary<string, DateTime>();
            for (int i = 0; i < allBooksIn.Books.Count; i++)
            {
                var bookRelease = allBooksIn.Books[i].ReleaseDate;
                var bookTitle = allBooksIn.Books[i].Title;

                if (!dictOfBooks.ContainsKey(bookTitle) && bookRelease > printAfterDate)
                {
                    dictOfBooks.Add(bookTitle, bookRelease);
                }
            }
            return dictOfBooks;
        }

        private static Book ReadAllBooks()
        {
            Book currBook = new Book();
            var input = Console.ReadLine().Split();
            currBook.Title = input[0];
            currBook.Author = input[1];
            currBook.Publisher = input[2];
            currBook.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            currBook.ISBNnumber = long.Parse(input[4]);
            currBook.Price = double.Parse(input[5]);

            return currBook;
        }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public long ISBNnumber { get; set; }
        public double Price { get; set; }
    }
}

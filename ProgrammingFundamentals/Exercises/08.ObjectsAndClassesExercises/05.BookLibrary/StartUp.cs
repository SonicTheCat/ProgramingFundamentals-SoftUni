namespace _05.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();


            for (int i = 0; i < n; i++)
            {
                books.Add(ReadBook());
            }

            Library booksInLibrary = new Library();
            booksInLibrary.Books = books;

            Dictionary<string, double> AddPriceAndAuthor = new Dictionary<string, double>();
            for (int i = 0; i < booksInLibrary.Books.Count; i++)
            {
                if (!AddPriceAndAuthor.ContainsKey(booksInLibrary.Books[i].Author))
                {
                    AddPriceAndAuthor.Add(booksInLibrary.Books[i].Author, 0);
                }
                AddPriceAndAuthor[booksInLibrary.Books[i].Author] += booksInLibrary.Books[i].Price;
            }

            foreach (var kvp in AddPriceAndAuthor.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }

        }

        private static Book ReadBook()
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Book currentBook = new Book();
            currentBook.Title = input[0];
            currentBook.Author = input[1];
            currentBook.Publisher = input[2];
            currentBook.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            currentBook.ISBNnumber = long.Parse(input[4]);
            currentBook.Price = double.Parse(input[5]);

            return currentBook;
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

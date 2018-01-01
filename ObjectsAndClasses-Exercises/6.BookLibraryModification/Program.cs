using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _6.BookLibraryModification
{
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
        public string IsbnNumber { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Library lib = new Library();
            lib.Books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                Book book = new Book();
                string[] input = Console.ReadLine().Split();

                book.Title = input[0];
                book.Author = input[1];
                book.Publisher = input[2];
                book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.IsbnNumber = input[4];
                book.Price = double.Parse(input[5]);

                lib.Books.Add(book);
            }

            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture );

            foreach (var book in lib.Books.OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title))
            {
                if (book.ReleaseDate > startDate)
                {
                    string date = book.ReleaseDate.ToString("dd.MM.yyyy");
                    Console.WriteLine("{0} -> {1}", book.Title, date);
                }
            }
        }
    }
}

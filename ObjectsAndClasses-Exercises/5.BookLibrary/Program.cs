using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.BookLibrary
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
                book.ReleaseDate = DateTime.Parse(input[3]);
                book.IsbnNumber = input[4];
                book.Price = double.Parse(input[5]);

                lib.Books.Add(book);
            }

            Dictionary<string, double> results = new Dictionary<string, double>();

            for (int book = 0; book < lib.Books.Count; book++)
            {
                if (!results.ContainsKey(lib.Books[book].Author))
                {
                    results.Add(lib.Books[book].Author, 0);
                }

                results[lib.Books[book].Author] += lib.Books[book].Price;
            }

            foreach (var author in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1:F2}", author.Key, author.Value);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedCSharpDemo
{

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public override string ToString()
        {
            return $"\"{Title}\" by {Author}, published in {Year}";
        }
    }


    public interface ILibraryManager
    {
        void AddBook(Book book);
        List<Book> GetBooksByAuthor(string author);
        Book GetOldestBook();
    }


    public class LibraryManager : ILibraryManager
    {
        private readonly List<Book> _books = new List<Book>();

        public void AddBook(Book book)
        {
            _books.Add(book);
            Console.WriteLine($"Added book: {book}");
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            return _books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Book GetOldestBook()
        {
            return _books.OrderBy(b => b.Year).FirstOrDefault();
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to the Library Management System!");
            ILibraryManager library = new LibraryManager();

            library.AddBook(new Book("1984", "George Orwell", 1949));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960));
            library.AddBook(new Book("Brave New World", "Aldous Huxley", 1932));
            library.AddBook(new Book("Animal Farm", "George Orwell", 1945));

            Console.WriteLine("\nFetching books by George Orwell...");
            var orwellBooks = library.GetBooksByAuthor("George Orwell");
            foreach (var book in orwellBooks)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\nFinding the oldest book...");
            var oldestBook = library.GetOldestBook();
            Console.WriteLine(oldestBook != null ? $"Oldest book: {oldestBook}" : "No books found.");

            Console.WriteLine("\nDemonstrating async operations...");
            await DemonstrateAsyncOperation();

            Console.WriteLine("\nProgram completed. Press any key to exit.");
            Console.ReadKey();
        }

        private static async Task DemonstrateAsyncOperation()
        {
            Console.WriteLine("Starting async operation...");
            await Task.Delay(2000); 
            Console.WriteLine("Async operation completed!");
        }
    }
}

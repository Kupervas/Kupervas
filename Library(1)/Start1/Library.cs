using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Start1
{
    internal class Library
    {
        private List<Book> books;
        private int _nextBookId = 1;
        public Library()
        {
            books = new List<Book>();
        }
        /*
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Books added successfully: {book.Title} - {book.Author} - {book.Year} ");
        }
        */
        public void AddbookWithId(Book book)
        {
            book.Id = _nextBookId++;
            books.Add(book);
            Console.WriteLine($"Books added successfully: {book.Title} - {book.Author} - {book.Year} ");
        }
        public void DisplayBooks()
        {
            Console.WriteLine("== Library Books ==");
            foreach (var book in books)
            {
                book.DisplayInfo();
            }
        }
        public void TakeBook(string title)
        {
            var book = books.FirstOrDefault(b => b.Title == title);
            if (book != null && book.IsAvailable)
            {
                book.IsAvailable = false;
                Console.WriteLine($"You have taken the book: {book.Title}");
            }
            else if (book != null && !book.IsAvailable)
            {
                Console.WriteLine($"The book '{book.Title}' is currently not available.");
            }
            else
            {
                Console.WriteLine($"The book '{title}' does not exist in the library.");
            }
        }
        public void ReturnBook(string title)
        {
            var book = books.FirstOrDefault(b => b.Title == title);
            if (book != null && !book.IsAvailable)
            {
                book.IsAvailable = true;
                Console.WriteLine($"You have returned the book: {book.Title}");
            }
            else if (book != null && book.IsAvailable)
            {
                Console.WriteLine($"The book '{book.Title}' was not taken out.");
            }
            else
            {
                Console.WriteLine($"The book '{title}' does not exist in the library.");
            }
        }
        public void DeleteBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine($"Book with ID {id} has been deleted.");
            }
            else
            {
                Console.WriteLine($"No book found with ID {id}.");

            }
        }
        public void DisplayAvailableBooks()
        {
            var availableBooks = books.Where(b => b.IsAvailable).ToList();
            if (availableBooks.Count > 0)
            {
                Console.WriteLine("=== Available Books ===");
                foreach (var book in availableBooks)
                {
                    book.DisplayInfo();
                }
            }
            if (availableBooks.Count == 0)
            {
                Console.WriteLine("No books are currently available.");
            }
        }
        public void SearchByAuthor(string author)
        {
            var booksByAuthor = books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
            if (booksByAuthor.Count > 0)
            {
                Console.WriteLine($"=== Books by {author} ===");
                foreach (var book in booksByAuthor)
                {
                    book.DisplayInfo();
                }
            }
            else
            {
                Console.WriteLine($"No books found by the author '{author}'.");
            }
        }
    }
}

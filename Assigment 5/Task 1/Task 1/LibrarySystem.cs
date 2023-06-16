using System;

namespace LibrarySystem
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }

    public class Library
    {
        private Book[] books;

        public Library(int capacity)
        {
            books = new Book[capacity];
        }

        public Book this[string title]
        {
            get
            {
                foreach (Book book in books)
                {
                    if (book != null && book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                        return book;
                }
                return null;
            }
        }

        public int Count
        {
            get { return books.Length; }
        }

        public void AddBook(Book book)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == null)
                {
                    books[i] = book;
                    return;
                }
            }
            Console.WriteLine("Library is full. Cannot add more books.");
        }

        public void RemoveBook(Book book)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == book)
                {
                    books[i] = null;
                    return;
                }
            }
            Console.WriteLine("Book not found in the library.");
        }

        public Book FindBook(string title)
        {
            foreach (Book book in books)
            {
                if (book != null && book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                    return book;
            }
            return null;
        }
    }
}

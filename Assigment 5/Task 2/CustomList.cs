using System;

namespace CustomLists
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
    public class CustomList
    {
        private Book[] books;
        private int count;

        public CustomList(int capacity)
        {
            books = new Book[capacity];
            count = 0;
        }

        public int Count
        {
            get { return count; }
        }

        public void AddElement(Book book)
        {
            if (count < books.Length)
            {
                books[count] = book;
                count++;
            }
            else
            {
                Console.WriteLine("List is full. Cannot add more elements.");
            }
        }

        public void AddList(Book[] bookList)
        {
            int spaceLeft = books.Length - count;
            int numElementsToAdd = Math.Min(spaceLeft, bookList.Length);
            Array.Copy(bookList, 0, books, count, numElementsToAdd);
            count += numElementsToAdd;
        }

        public void InsertElement(int index, Book book)
        {
            if (index >= 0 && index <= count)
            {
                if (count < books.Length)
                {
                    Array.Copy(books, index, books, index + 1, count - index);
                    books[index] = book;
                    count++;
                }
                else
                {
                    Console.WriteLine("List is full. Cannot insert element.");
                }
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        public void InsertList(int index, Book[] bookList)
        {
            if (index >= 0 && index <= count)
            {
                int spaceLeft = books.Length - count;
                int numElementsToAdd = Math.Min(spaceLeft, bookList.Length);
                Array.Copy(books, index, books, index + numElementsToAdd, count - index);
                Array.Copy(bookList, 0, books, index, numElementsToAdd);
                count += numElementsToAdd;
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        public Book GetElement(int index)
        {
            if (index >= 0 && index < count)
            {
                return books[index];
            }
            else
            {
                Console.WriteLine("Invalid index.");
                return null;
            }
        }

        public Book[] GetList()
        {
            Book[] result = new Book[count];
            Array.Copy(books, result, count);
            return result;
        }

        public void RemoveElement(int index)
        {
            if (index >= 0 && index < count)
            {
                Array.Copy(books, index + 1, books, index, count - index - 1);
                count--;
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }

        public void RemoveList(Book[] bookList)
        {
            foreach (Book book in bookList)
            {
                int index = Array.IndexOf(books, book, 0, count);
                if (index >= 0)
                {
                    Array.Copy(books, index + 1, books, index, count - index - 1);
                    count--;
                }
            }
        }

        public void Clear()
        {
            Array.Clear(books, 0, count);
            count = 0;
        }

        public Book Find(Predicate<Book> match)
        {
            Book result = Array.Find(books, match);
            return result;
        }
    }
}

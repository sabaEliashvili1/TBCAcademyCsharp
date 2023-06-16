using System;
using LibrarySystem;



Library library = new Library(5);

library.AddBook(new Book { Title = "Book 1", Author = "Author 1", Year = 2020 });
library.AddBook(new Book { Title = "Book 2", Author = "Author 2", Year = 2019 });
library.AddBook(new Book { Title = "Book 3", Author = "Author 3", Year = 2021 });

Book book = library["Book 2"];
if (book != null)
    Console.WriteLine($"Found book: {book.Title} by {book.Author}, {book.Year}");


Book bookToRemove = library.FindBook("Book 1");
if (bookToRemove != null)
    library.RemoveBook(bookToRemove);

Console.WriteLine($"Number of books in the library: {library.Count}");

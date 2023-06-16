using CustomLists;

CustomList customList = new CustomList(5);

customList.AddElement(new Book { Title = "Book 1", Author = "Author 1", Year = 2020 });
customList.AddElement(new Book { Title = "Book 2", Author = "Author 2", Year = 2019 });

customList.InsertElement(1, new Book { Title = "Book 3", Author = "Author 3", Year = 2021 });

Book book = customList.GetElement(0);
if (book != null)
    Console.WriteLine($"Element at index 0: {book.Title} by {book.Author}, {book.Year}");

customList.RemoveElement(1);

Book[] bookList = customList.GetList();
foreach (Book b in bookList)
{
    Console.WriteLine($"{b.Title} by {b.Author}, {b.Year}");
}

customList.Clear();

Book[] newBooks = new Book[]
{
            new Book { Title = "Book 4", Author = "Author 4", Year = 2022 },
            new Book { Title = "Book 5", Author = "Author 5", Year = 2023 }
};
customList.AddList(newBooks);

Book foundBooks = customList.Find(book => book.Year > 2020);
Console.WriteLine($"{foundBooks.Title} by {foundBooks.Author}, {foundBooks.Year}");

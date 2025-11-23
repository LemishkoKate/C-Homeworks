using System;
using System.Collections.Generic;

class Book : IDisposable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int Pages { get; set; }

    private bool disposed = false;

    public Book(string title, string author, int year, int pages)
    {
        Title = title;
        Author = author;
        Year = year;
        Pages = pages;
        Console.WriteLine($"Створено книгу: {Title}");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Назва: {Title}, Автор: {Author}, Рік: {Year}, Сторінки: {Pages}");
    }

    public void Dispose()
    {
        if (!disposed)
        {
            Console.WriteLine($"Dispose викликано для книги: {Title}");
            disposed = true;
            GC.SuppressFinalize(this);
        }
    }

    ~Book()
    {
        Console.WriteLine($"Фіналізатор викликано для книги: {Title}");
    }
}

class Library : IDisposable
{
    private List<Book> books = new List<Book>();
    private bool disposed = false;

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Додано книгу до бібліотеки: {book.Title}");
    }

    public void ShowAllBooks()
    {
        Console.WriteLine("\nСписок книг у бібліотеці:");
        foreach (var book in books)
        {
            book.ShowInfo();
        }
    }

    public void Dispose()
    {
        if (!disposed)
        {
            Console.WriteLine("Dispose викликано для бібліотеки. Очищення списку книг...");
            books.Clear();
            disposed = true;
            GC.SuppressFinalize(this);
        }
    }

    ~Library()
    {
        Console.WriteLine("Фіналізатор викликано для бібліотеки.");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Тестування класу Book ===");
        Book b1 = new Book("Кобзар", "Т. Шевченко", 1840, 500);
        Book b2 = new Book("Майстер і Маргарита", "М. Булгаков", 1967, 600);
        
        b1.ShowInfo();
        b2.ShowInfo();

        b1.Dispose();
        b2.Dispose();

        Console.WriteLine("\n=== Тестування класу Library ===");
        using (Library lib = new Library())
        {
            lib.AddBook(new Book("Гаррі Поттер", "Дж. Роулінг", 1997, 350));
            lib.AddBook(new Book("1984", "Дж. Орвелл", 1949, 300));
            lib.ShowAllBooks();
        }

        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("\n=== Кінець тестування ===");
    }
}

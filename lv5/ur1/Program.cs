using System;

class Program
{
    static void Main(string[] args)
    {
        Book myBook = new Book();
        myBook.title = "Мастер и Маргарита";
        myBook.author = "Михаил Булгаков";
        myBook.year = 1967;

        myBook.DisplayInfo();

        Console.WriteLine($"Название: {myBook.title}");
        Console.WriteLine($"Автор: {myBook.author}");
        Console.WriteLine($"Год: {myBook.year}");
    }
}
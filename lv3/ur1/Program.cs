using System;
using ur1;
class Program
{
    static void Main(string[] args)
    {
        Book myBook = new Book();
        myBook.title = "Война и мир";
        myBook.author = "Лев Толстой";
        myBook.year = 1869;
        myBook.GetInfo();

        Book unknownBook = new Book();
        unknownBook.GetInfo();
    }
}
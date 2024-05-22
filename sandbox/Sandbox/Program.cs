using System;
using library_demo;

class Program
{
    static void Main(string[] args)
    {
       Book book1 = new Book();
       book1.SetAuthor("Smith");
       book1.SetTitle("A Great Book");

       Console.WriteLine(book1.GetBookInfo());

       PictureBook book2 = new PictureBook();
       book2.SetAuthor("Jones");
       book2.SetTitle("A Wonderful Picture Book");
       book2.SetIllustrator("Burton");

       Console.WriteLine(book2.GetBookInfo());
       Console.WriteLine(book2.GetPictureBookInfo());

       Book book3 = new Book("Edwards", "Another Book");
       Console.WriteLine(book3.GetBookInfo());

       PictureBook book4 = new PictureBook("Jackson", "Yet Another Book", "Wales");
       Console.WriteLine(book4.GetPictureBookInfo());
    }
}
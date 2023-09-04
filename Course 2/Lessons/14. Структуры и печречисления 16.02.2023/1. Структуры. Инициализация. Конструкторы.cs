
using System;

struct Book
{
    public string author;
    public string title;
    public int copyright;
    public Book(string a, string t, int c)
    {
        author = a;
        title = t;
        copyright = c;
    }
}

class StructDemo
{
    public static void Main()
    {
        Book bookl = new Book("Herb Schildt", "C# A Beginner's Guide", 2001); // Вызов явно заданного конструктора.
        Book book2 = new Book(); // Вызов конструктора по умолчанию.
        Book book3; // Создание объекта без вызова  конструктора.
        Console.WriteLine(bookl.title + ", автор " + bookl.author + ", (с) " + bookl.copyright);
        Console.WriteLine();
        if (book2.title == null)
            Console.WriteLine("Поле book2.title содержит null.");

        book2.title = "С# и платформа .NET. Библиотека программиста";
        book2.author = "Троелсен. Э.";
        book2.copyright = 2001;
        Console.Write("Теперь структура book2 содержит:\n ");
        Console.WriteLine(book2.title + ", автор " + book2.author + ", (c) " + book2.copyright);
        Console.WriteLine();
        // Console.WriteLine(bоок3.title); // Ошибка: сначала  необходима инициализация.
        book3.title = "Программирование на платформе Microsoft .NET Framework";
        book3.author = "Рихтер Дж.";
        book3.copyright = 2003;
        Console.WriteLine(book3.title + ", автор " + book3.author + ", (c) " + book3.copyright);
    }
}

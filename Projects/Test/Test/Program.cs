using System;
using System.Net.NetworkInformation;
using HtmlAgilityPack;

public class Program
{

    class MyClass
    {
        public int a;
        public int b;
        public int c;
    }

    static void Foo( MyClass obj)
    {
        obj.a = 111;
        obj.b = 222;
        obj.c = 333;
    }

    public static void Main()
    {
        MyClass obj = new MyClass();

        Foo( obj);

        Console.WriteLine($"a: {obj.a}\nb: {obj.b}\nc: {obj.c}");
     }
}

// Демонстрация порядка выполнения конструкторов.
using System;

class A
{
    public A()
    {
        Console.WriteLine("Создание класса А.");
    }
}

class B : A
{
    public B()
    {
        Console.WriteLine("Создание класса В.");
    }
}

class C : B
{
    public C()
    {
        Console.WriteLine("Создание класса С.");
    }
}

class OrderOfConstruction
{
    public static void Main()
    {
        C c = new C();
    }
}
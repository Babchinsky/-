// Демонстрация порядка вызова конструкторов.
using System;
// Создаем базовый класс
class A
{
    public A()
    {
        Console.WriteLine("Создание класса А.");
    }
}

// Создаем класс, производный от А
class B : A
{
    public B()
    {
        Console.WriteLine("Создание класса В.");
    }
}

// Создаем класс, производный от В
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
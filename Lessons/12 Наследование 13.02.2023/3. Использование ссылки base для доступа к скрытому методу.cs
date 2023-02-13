// Пример сокрытия имени в связи с наследованием.
using System;
class A
{
    int i = 0;
    public A(int a)
    {
        i = a; // Член i в классе A.
    }
    public void show()
    {
        Console.WriteLine("Член i в базовом классе A: " + i);
    }
}

// Создаем производный класс
class B : A
{
    int i; 
    public B(int a, int b)
        : base(a)
    {
        i = b; // Член i в классе В.
    }
    new public void show()
    {
        base.show();
        Console.WriteLine("Член i в производном классе B: " + i);
    }
}

class C : B
{
    int i;
    public C(int a, int b, int c)
        : base(a, b)
    {
        i = c; // Член i в классе C.
    }
    new public void show()
    {
        base.show();
        Console.WriteLine("Член i в производном классе C: " + i);
    }
}

class MainClass
{
    public static void Main()
    {
        C ob = new C(1, 2, 3);
        ob.show();
    }
}

// Использование явной реализации для того, чтобы избежать неоднозначности

using System;

interface IMyIF_A
{
    int meth(int x);
}

interface IMyIF_B
{
    int meth(int x);  
}

class A : IMyIF_A, IMyIF_B
{
    // Одна общая реализация для обоих интерфейсов
    public int meth(int x)
    {
        return x + x;
    }
}

// В классе MyClass реализованы оба интерфейса
class B : IMyIF_A, IMyIF_B
{
    // Явным образом реализуем два метода meth()
    int IMyIF_A.meth(int x)
    {
        return x + x;
    }
    int IMyIF_B.meth(int x)
    {
        return x * x;
    }
    // Вызываем метод meth() посредством ссылки на интерфейс
    public int methA(int x)
    {
        IMyIF_A a_ob;
        a_ob = this;
        return a_ob.meth(x); // Имеется в виду интерфейс IMyIF_A
    }
    public int methB(int x)
    {
        IMyIF_B b_ob;
        b_ob = this;
        return b_ob.meth(x); // Имеется в виду интерфейс IMyIF_B
    }
}

class MainClass
{
    public static void Main()
    {
        A obj1 = new A();
        Console.Write("Вызов метода A.meth(): ");
        Console.WriteLine(obj1.meth(7));
        IMyIF_A ia = obj1;
        Console.Write("Вызов метода IMyIF_A.meth(): ");
        Console.WriteLine(ia.meth(7));
        IMyIF_B ib = obj1;
        Console.Write("Вызов метода IMyIF_B.meth(): ");
        Console.WriteLine(ib.meth(7));

        B obj2 = new B();
        Console.Write("Вызов метода IMyIF_A.meth(): ");
        Console.WriteLine(obj2.methA(3));
        Console.Write("Вызов метода IMyIF_B.meth(): ");
        Console.WriteLine(obj2.methB(3));

        IMyIF_A a = obj2;
        Console.Write("Вызов метода IMyIF_A.meth(): ");
        Console.WriteLine(a.meth(4));
        Console.Write("Вызов метода IMyIF_B.meth(): ");
        Console.WriteLine((obj2 as IMyIF_B).meth(4));
    }
}
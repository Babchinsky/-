// Использование ссылки base для доступа к скрытому имени.
using System;
class A
{
    public int i = 0;
}
// Создаем производный класс,
class В : A
{
    new int i; // Эта переменная i скрывает i класса А.
    public В(int a, int b)
    {
        base.i = a; // Так можно обратиться к i класса А.
        i = b; // Переменная i в классе В.
    }
    public void show()
    {
        // Эта инструкция отображает переменную i в классе А.
        Console.WriteLine("i в базовом классе: " + base.i);
        // Эта инструкция отображает переменную i в классе В.
        Console.WriteLine("i в производном классе: " + i);
    }
}

class MainClass
{
    public static void Main()
    {
        В ob = new В(1, 2);
        ob.show();
        ob.i = 100;
        ob.show();
    }
}
using System;

class MainClass
{
    static Random rnd = new Random();
    public static IFigure GeneratorOfFigures()
    {
        int n = rnd.Next(2);
        switch (n)
        {
            case 0: return new rectangle(10.5, 6.5);
            case 1: return new circle(10);
            default: return null;
        }
    }
    static void Main()
    {
        rectangle rect = new rectangle(8, 10);
        rect.FigureType();
        rect.area();
        rect.Diagonal();
        rect.PropA = 6;
        rect.PropB = 7;
        rect.area();
        rect.Diagonal();
        rect.Perimetr();

        circle crl = new circle(12);
        crl.FigureType();
        crl.area();
        crl.Length();
        crl.PropA = 6;
        crl.area();
        crl.Length();

        IFigureAngle obj = rect;
        obj.FigureType();
        obj.area();
        obj.Diagonal();
        obj.PropA = 3;
        obj.PropB = 4;
        obj.area();
        obj.Diagonal();
        (obj as rectangle).Perimetr(); // Такого метода в интерфейсе нет

        IFigureRound obj2 = crl;
        obj2.FigureType();
        obj2.area();
        obj2.Length();
        obj2.PropA = 3;
        obj2.area();
        obj2.Length();

        IFigure[] p = new IFigure[10];
        int count_rectangle = 0, count_circle = 0;
        for (int i = 0; i < 10; i++)
        {
            p[i] = GeneratorOfFigures();
            if (p[i] is IFigureAngle)
                count_rectangle++;
            if (p[i] is IFigureRound)
                count_circle++;
            p[i].FigureType();
        }
        Console.WriteLine("\nКоличество прямоугольников: " + count_rectangle);
        Console.WriteLine("Количество окружностей: " + count_circle);
        count_rectangle = 0;
        count_circle = 0;

        for (int i = 0; i < 10; i++)
        {
            p[i] = GeneratorOfFigures();
            if (p[i] as IFigureAngle != null)
                count_rectangle++;
            if (p[i] as IFigureRound != null)
                count_circle++;
            p[i].FigureType();
        }
        Console.WriteLine("\nКоличество прямоугольников: " + count_rectangle);
        Console.WriteLine("Количество окружностей: " + count_circle);
    }
}
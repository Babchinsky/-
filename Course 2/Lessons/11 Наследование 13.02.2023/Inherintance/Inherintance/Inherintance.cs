using System;
class TwoDShape
{
    double pri_width; 
    double pri_height; 

    public TwoDShape()
        : this(0, 0)
    {
    }

    public TwoDShape(double w, double h)
    {
        width = w;
        height = h;
    }

    public TwoDShape(double x)
        : this(x, x)
    {

    }

    public double width
    {
        get { return pri_width; }
        set { pri_width = value; }
    }
    public double height
    {
        get { return pri_height; }
        set { pri_height = value; }
    }
    public void showDim()
    {
        Console.WriteLine("Ширина и высота равны " + width + " и " + height);
    }
}


class Triangle : TwoDShape
{
    string style; 

    public Triangle()
        : this(null, 0, 0)
    {

    }

    public Triangle(string s, double w, double h)
        : base(w, h)
    {
        style = s;
    }


    public Triangle(double x)
        : base(x)
    {
        style = "равнобедренный";
    }

    public double area()
    {
        return width * height / 2;
    }

    public void showStyle()
    {
        Console.WriteLine("Треугольник " + style);
    }
}


class ColorTriangle : Triangle
{
    string color;
    public ColorTriangle(string c, string s, double w, double h)
        : base(s, w, h)
    {
        color = c;
    }

    public void showColor()
    {
        Console.WriteLine("Цвет " + color);
    }
}

class MainClass
{
    public static void Main()
    {
        ColorTriangle tl = new ColorTriangle("синий", "прямоугольный", 8.0, 12.0);
        ColorTriangle t2 = new ColorTriangle("красный", "равнобедренный", 2.0, 2.0);
        Console.WriteLine("Информация о tl: ");
        tl.showStyle();
        tl.showDim();
        tl.showColor();
        Console.WriteLine("Площадь равна " + tl.area());
        Console.WriteLine();
        Console.WriteLine("Информация о t2: ");
        t2.showStyle();
        t2.showDim();
        t2.showColor();
        Console.WriteLine("Площадь равна " + t2.area());
    }
}
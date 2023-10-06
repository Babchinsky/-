delegate int MyDelegate(int a, int b);
class Program
{
    public static int Max(int a, int b)
    {
        return Math.Max(a, b);
    }
    public static int Min(int a, int b)
    {
        return Math.Min(a, b);
    }
    public static int Sum(int a, int b)
    {
        return a + b;
    }
    public static int Mult(int a, int b)
    {
        return a * b;
    }
    public static void Main(string[] args)
    {
        MyDelegate dg = new MyDelegate(Max);
        dg += Sum;
        dg += Min;
        dg += Mult;
        Console.WriteLine(dg(10,20));
    }
}


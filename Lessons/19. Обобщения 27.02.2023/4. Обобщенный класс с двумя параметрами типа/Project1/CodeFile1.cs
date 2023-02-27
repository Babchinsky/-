using System;

class TwoGen<T, V>
{
    T ob1;
    V ob2;

    public TwoGen(T o1, V o2)
    {
        ob1 = o1;
        ob2 = o2;
    }

    public void showTypes()
    {
        Console.WriteLine("Type of T is " + typeof(T));
        Console.WriteLine("Type of V is " + typeof(V));
    }

    public T GetObj1
    {
        get { return ob1; }
    }

    public V GetObj2
    {
        get { return ob2; }
    }
}

class SimpGen
{
    static void Main()
    {

        TwoGen<int, string> tgObj =
          new TwoGen<int, string>(7, "generics");

        tgObj.showTypes();

        int v = tgObj.GetObj1;
        Console.WriteLine("value: " + v);

        string str = tgObj.GetObj2;
        Console.WriteLine("value: " + str);
    }
}

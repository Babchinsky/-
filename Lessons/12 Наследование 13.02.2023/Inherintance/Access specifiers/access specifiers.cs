using System;
using ClassLibrary1;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj1 = new DerivedClass();
            obj1.c = 111;
            obj1.h = 222;
            obj1.Show();
            Derived2 obj2 = new Derived2();
            obj2.Show();
            obj2.k = 100;
            Console.WriteLine("{0}   {1}   {2}   {3}", obj2.o, obj2.k, obj2.h, obj2.c);
        }
    }

    public class Derived2 : DerivedClass
    {
        private int m = 50;
        protected int n = 60;
        public int o = 70;
        internal protected int k = 80;
        new internal void Show()
        {
            base.Show();
            Console.WriteLine("{0}   {1}   {2}   {3}   {4}   {5}   {6}   {7}   {8}   {9}", m, n, o, k, b, c, d, g, h, i);
        }
    }
}

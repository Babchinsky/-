using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class BaseClass
    {
        private int a = 10;
        protected int b = 20;
        public int c = 30;
        internal protected int d = 40;
        internal void Show()
        {
            Console.WriteLine("{0}   {1}   {2}   {3}", a, b, c, d);
        }
    }

    public class DerivedClass : BaseClass
    {
        private int e = 50;
        protected int g = 60;
        public int h = 70;
        internal protected int i = 80;
        new public void Show()
        {
            base.Show();
            Console.WriteLine("{0}   {1}   {2}   {3}   {4}   {5}   {6}", e, g, h, i, b, c, d);
        }
    }
}

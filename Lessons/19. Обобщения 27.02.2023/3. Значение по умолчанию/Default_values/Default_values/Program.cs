using System;

namespace Default_values
{
    class MyGeneric<T>
    {
        T var;
        public T PropVal
        {
            get
            {
                return var;
            }
            set
            {
                var = value;
            }
        }
        public void Reset()
        {
            // Оператор default(T) присваивает ссылочным типам в качестве значения null, 
            // а типам значений - значение 0
            var = default(T);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyGeneric<int> obj1 = new MyGeneric<int>();
            obj1.PropVal = 7;
            Console.WriteLine(obj1.PropVal);
            obj1.Reset();
            Console.WriteLine(obj1.PropVal);
            MyGeneric<string> obj2 = new MyGeneric<string>();
            obj2.PropVal = "Generic";
            Console.WriteLine(obj2.PropVal);
            obj2.Reset();
            Console.WriteLine(obj2.PropVal);
        }
    }
}

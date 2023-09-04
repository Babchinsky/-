using System;

namespace CSharp.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.ShowName(); // экземплярный метод
            Student.ShowAcademy(); // статический метод
            Console.WriteLine("Оценка: {0}", st1.GetMark());

            Console.WriteLine("Конструктор по умолчанию");
            Car myCar = new Car();
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }

            Console.WriteLine("\n\nКонструктор с параметрами");
            myCar = new Car("Рубенс Барикелло");
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
        }
    }
}

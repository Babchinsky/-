using System;

namespace Lesson
{
    internal class MainClass
    {
        public static void Main()
        {
            Human[] ptr= new Human[2];
            ptr[0] = new Student("Ivan", 20, "IT STEP");
            //Console.WriteLine(ptr);
            ptr[0].Print();

            ptr[1] = new Teacher("Victor", 40, "IT STEP");
            //Console.WriteLine(ptr);
            ptr[1].Print();
        }
    }
}

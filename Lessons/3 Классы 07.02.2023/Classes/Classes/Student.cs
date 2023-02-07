using System;

namespace CSharp.Classes
{
   internal class Student
    {
        public int studentID = 0;
        public string firstName = "Петр";
        public string lastName = null;
        public string group = null;

        private static string academyName = "Компьютерная Академия \"ШАГ\"";

        public void ShowName()
        {
            Console.WriteLine(firstName);
        }

        public static void ShowAcademy() => Console.WriteLine(academyName);

        public int GetMark() => new Random().Next(1, 12);
    }
}

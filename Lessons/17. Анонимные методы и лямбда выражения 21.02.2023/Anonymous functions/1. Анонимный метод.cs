using System;
using System.IO;
using System.Text;
using System.Threading;

namespace Anonymous_meth210ods
{
    // Иногда основанием для существования метода служит то обстоятельство, 
    // что он должен быть вызван только один раз посредством делегата. 
    // В подобных случаях можно воспользоваться анонимной функцией, чтобы не  создавать отдельный метод.
    // Анонимная функция, по существу, представляет собой безымянный кодовый блок, 
    // передаваемый конструктору делегата. 
    // Преимущество анонимной функции состоит, в частности, в ее простоте. 
    // Благодаря ей отпадает необходимость объявлять отдельный метод, 
    // единственное назначение которого состоит в том, что он передается делегату.
      
    delegate void MyDelegate(string message);
    
    class MainClass
    {
        static void ShowMessage(string message, MyDelegate handler)
        {
            handler(message);
        }
        public static void Main()
        {
            //1
            MyDelegate obj = delegate (string message)
            {
                Console.WriteLine(message);
            };
            obj("Hello world");

            ////2
            //ShowMessage("hello!", delegate (string mes)
            //{
            //    Console.WriteLine(mes);
            //});
            //ShowMessage("Hello", delegate (string mes)
            //{
            //    Console.WriteLine(mes + " = Привет!");
            //});


        }
    }
}



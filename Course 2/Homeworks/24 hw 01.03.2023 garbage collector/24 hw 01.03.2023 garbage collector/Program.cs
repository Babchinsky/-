using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1();
            Task_2();
        }
        static void Task_1()
        {
            //Piece piece1 = new Piece("Hamlet", "William Shakespeare", "Tragedy", 1602);
            //Console.WriteLine(piece1);

            //// Testing the properties
            //piece1.Name = "Romeo and Juliet";
            //piece1.Author = "William Shakespeare";
            //piece1.Genre = "Tragedy";
            //piece1.Year = 1597;
            //Console.WriteLine(piece1);

            //// Call the destructor explicitly
            //piece1 = null;
            //GC.Collect();


            using (Piece piece1 = new Piece("Hamlet", "William Shakespeare", "Tragedy", 1602))
            {
                Console.WriteLine(piece1);

                // Testing the properties
                piece1.Name = "Romeo and Juliet";
                piece1.Author = "William Shakespeare";
                piece1.Genre = "Tragedy";
                piece1.Year = 1597;
                Console.WriteLine(piece1);
            }
        }
        static void Task_2()
        {
            //var store = new Store("Groceries", "10 Pushkin St.", "Grocery");
            //store.Greeting();
            //store.Advertisement();
            //store.Sale("Bread");
            //store.Dispose();

            //using (var store = new Store("Groceries", "10 Pushkin St.", "Grocery"))
            //{
            //    store.Greeting();
            //    store.Advertisement();
            //    store.Sale("Bread");
            //    store.Farewell();
            //}

            var store = new Store("Groceries", "10 Pushkin St.", "Grocery");
            // Call the destructor explicitly
            store = null;
            GC.Collect();
        }
    }
}

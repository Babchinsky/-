using System;

namespace nameof_Operator
{
    // Оператор nameof возвращает строковый литерал передаваемого в него элемента
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    /* MVVM
    INotifyPropertyChanged:
       public int Count
        {
            get { return Book.Count; }
            set
            {
                Book.Count = value;
                OnPropertyChanged("Count");
            }
        }
        public int Count
        {
            get { return Book.Count; }
            set
            {
                Book.Count = value;
                OnPropertyChanged(nameof(Count));
            }
        }
    */

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User user = new User { Name = "Ivan", Age = 30 };
                User user2 = new User();
                if (user.Name != null)
                    Console.WriteLine($"Name = {user.Name}, Age = {user.Age}");
                else throw new ArgumentNullException(nameof(user.Name));
                if (user2.Name != null)
                    Console.WriteLine($"Name = {user2.Name}, Age = {user2.Age}");
                else throw new ArgumentNullException(nameof(user2.Name));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

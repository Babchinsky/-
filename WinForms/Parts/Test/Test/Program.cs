using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test
{
    internal class Task
    {
        private string Question { get; set; }
        private Dictionary<string, bool> Answers;

        public Task(string question, Dictionary<string, bool> answers)
        {
            Question = question;
            Answers = answers;
        }

        public void Show()
        {
            Console.WriteLine(Question);

            foreach (var answer in Answers)
            {
                Console.WriteLine(answer.Key + " " + answer.Value);
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Dictionary<string, bool> answers1 = new Dictionary<string, bool>();
            answers1.Add("Java", true);
            answers1.Add("Python", false);
            answers1.Add("C#", false);
            answers1.Add("Ruby", false);

            Task task1 = new Task("Какой язык программирования используется для создания приложений на Android?", answers1);

            // Task 2
            Dictionary<string, bool> answers2 = new Dictionary<string, bool>();
            answers2.Add("Рейнджерс", false);
            answers2.Add("Кельт", false);
            answers2.Add("Ливерпуль", true);
            answers2.Add("Челси", false);

            Task task2 = new Task("Какой из этих футбольных клубов является обладателем наибольшего числа титулов чемпиона Англии?", answers2);

            // Task 3
            Dictionary<string, bool> answers3 = new Dictionary<string, bool>();
            answers3.Add("Samsung", false);
            answers3.Add("Apple", true);
            answers3.Add("Nokia", false);
            answers3.Add("Sony", false);

            Task task3 = new Task("Какая компания выпускает iPhone?", answers3);

            // Task 4
            Dictionary<string, bool> answers4 = new Dictionary<string, bool>();
            answers4.Add("Замбия", false);
            answers4.Add("Кения", true);
            answers4.Add("Мали", false);
            answers4.Add("Сенегал", false);

            Task task4 = new Task("В какой из этих африканских стран находится город Найроби?", answers4);

            // Task 5
            Dictionary<string, bool> answers5 = new Dictionary<string, bool>();
            answers5.Add("Панама", false);
            answers5.Add("Колумбия", false);
            answers5.Add("Венесуэла", false);
            answers5.Add("Эквадор", true);

            Task task5 = new Task("Какая из этих стран не имеет выхода к Карибскому морю?", answers5);

            // Task 6
            Dictionary<string, bool> answers6 = new Dictionary<string, bool>();
            answers6.Add("Россия", false);
            answers6.Add("Франция", false);
            answers6.Add("Италия", true);
            answers6.Add("Аргентина", false);

            Task task6 = new Task("В какой из этих стран находится город Венеция?", answers6);

            // Task 7
            Dictionary<string, bool> answers7 = new Dictionary<string, bool>();
            answers7.Add("Гомер Симпсон", false);
            answers7.Add("Джек Спарроу", false);
            answers7.Add("Хью Хефнер", true);
            answers7.Add("Леонардо да Винчи", false);

            Task task7 = new Task("Кто является основателем журнала Playboy?", answers7);

            // Task 8
            Dictionary<string, bool> answers8 = new Dictionary<string, bool>();
            answers8.Add("Нелсон Мандела", false);
            answers8.Add("Конон Дойл", false);
            answers8.Add("Владимир Ленин", true);
            answers8.Add("Джордж Оруэлл", false);

            Task task8 = new Task("Кто из перечисленных является основателем Советского государства?", answers8);

            // Task 9
            Dictionary<string, bool> answers9 = new Dictionary<string, bool>();
            answers9.Add("Пикассо", false);
            answers9.Add("Леонардо да Винчи", false);
            answers9.Add("Рафаэль", false);
            answers9.Add("Винсент Ван Гог", true);

            Task task9 = new Task("Кто из этих художников срезал себе ухо?", answers9);

            List<Task> tasks = new List<Task>();
            tasks.Add(task1);
            tasks.Add(task2);
            tasks.Add(task3);
            tasks.Add(task4);
            tasks.Add(task5);
            tasks.Add(task6);
            tasks.Add(task7);
            tasks.Add(task8);
            tasks.Add(task9);


            List<Task> randomizedTasks = tasks.OrderBy(x => Guid.NewGuid()).ToList();


            foreach (var item in randomizedTasks)
            {
                item.Show();
            }


        }
    }
}

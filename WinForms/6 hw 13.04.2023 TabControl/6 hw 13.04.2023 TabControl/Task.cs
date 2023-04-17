using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_hw_13._04._2023_TabControl
{
    internal class Task
    {
        public string Question { get; set; }
        public Dictionary<string, bool> Answers;

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
}

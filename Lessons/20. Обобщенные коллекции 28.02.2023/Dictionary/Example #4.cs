using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initialization_dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countries = new Dictionary<string, string>
                {
                    {"Франция", "Париж"},
                    {"Германия", "Берлин"},
                    {"Великобритания", "Лондон"}
                };

            foreach (var pair in countries)
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);

            countries = new Dictionary<string, string>
            {
                ["Украина"] = "Киев",
                ["Испания"] = "Мадрид",
                ["Австрия"] = "Вена"
            };

            foreach (var pair in countries)
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
        }
    }
}

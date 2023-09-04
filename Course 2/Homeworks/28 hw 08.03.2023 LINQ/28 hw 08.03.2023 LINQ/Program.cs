using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_hw_08._03._2023_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаём список
            List<Firm> firms = new List<Firm>()
            {
                new Firm() { Name = "Food Corp", FoundationDate = new DateTime(2000, 1, 1), BusinessProfile = "Food", DirectorFullName = "John White", EmployeeCount = 50, Address = "London" },
                new Firm() { Name = "Tech Solutions", FoundationDate = new DateTime(2005, 3, 15), BusinessProfile = "IT", DirectorFullName = "Mary Johnson", EmployeeCount = 150, Address = "New York" },
                new Firm() { Name = "Marketing Agency", FoundationDate = new DateTime(2010, 5, 7), BusinessProfile = "Marketing", DirectorFullName = "Robert Black", EmployeeCount = 200, Address = "London" },
                new Firm() { Name = "Food Services", FoundationDate = new DateTime(2015, 7, 21), BusinessProfile = "Food", DirectorFullName = "Michael Green", EmployeeCount = 80, Address = "Paris" },
                new Firm() { Name = "Software Solutions", FoundationDate = new DateTime(2018, 9, 3), BusinessProfile = "IT", DirectorFullName = "Emily Brown", EmployeeCount = 250, Address = "San Francisco" }
            };

            // Запросы к массиву фирм
            // 1) Получить информацию обо всех фирмах
            Console.WriteLine("All firms:");
            foreach (var firm in firms)
            {
                Console.WriteLine($"{firm.Name} - {firm.FoundationDate.ToShortDateString()} - {firm.BusinessProfile} - {firm.DirectorFullName} - {firm.EmployeeCount} - {firm.Address}");
            }

            // 2) Получить фирмы, у которых в названии есть слово Food
            Console.WriteLine("\nFirms with 'Food' in name:");
            var foodFirms = firms.FindAll(f => f.Name.Contains("Food"));
            foreach (var firm in foodFirms)
            {
                Console.WriteLine($"{firm.Name} - {firm.FoundationDate.ToShortDateString()} - {firm.BusinessProfile} - {firm.DirectorFullName} - {firm.EmployeeCount} - {firm.Address}");
            }

            // 3) Получить фирмы, которые работают в области маркетинга
            Console.WriteLine("\nFirms in marketing:");
            var marketingFirms = firms.FindAll(f => f.BusinessProfile == "Marketing");
            foreach (var firm in marketingFirms)
            {
                Console.WriteLine($"{firm.Name} - {firm.FoundationDate.ToShortDateString()} - {firm.BusinessProfile} - {firm.DirectorFullName} - {firm.EmployeeCount} - {firm.Address}");
            }

            // 4)  Получить фирмы, которые работают в области маркетинга или IT
            var marketingOrITCompanies = firms.Where(f => f.BusinessProfile == "маркетинг" || f.BusinessProfile == "IT");

            // 5)  Получить фирмы с количеством сотрудников, большем 100
            var companiesWithMoreThan100Employees = firms.Where(f => f.EmployeeCount > 100);

            // 6)  Получить фирмы с количеством сотрудников в диапазоне от 100 до 300
            var companiesWith100To300Employees = firms.Where(f => f.EmployeeCount >= 100 && f.EmployeeCount <= 300);

            // 7)   Получить фирмы, которые находятся в Лондоне
            var londonCompanies = firms.Where(f => f.Address.Contains("Лондон"));

            // 8)  Получить фирмы, у которых фамилия директора White
            var whiteDirectorCompanies = firms.Where(f => f.DirectorFullName.EndsWith("White"));

            // 9)  Получить фирмы, которые основаны больше двух лет назад
            var companiesFoundedMoreThan2YearsAgo = firms.Where(f => (DateTime.Now - f.FoundationDate).TotalDays > 730);

            // 10)  Получить фирмы со дня основания, которых прошло 123 дня
            var companiesFounded123DaysAgo = firms.Where(f => (DateTime.Now - f.FoundationDate).TotalDays == 123);

            // 11)  Получить фирмы, у которых фамилия директора Black и название фирмы содержит слово White
            var blackDirectorWhiteNameCompanies = firms.Where(f => f.DirectorFullName.EndsWith("Black") && f.Name.Contains("White"));
        }
    }
}

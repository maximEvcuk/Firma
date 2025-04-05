using System;
using System.Linq;
using System.Collections.Generic;

public class Firma
{
    public string Name { get; set; }
    public DateTime FoundedDate { get; set; }
    public string BusinessProfile { get; set; }
    public string DirectorFullName { get; set; }
    public int EmployeesCount { get; set; }
    public string Address { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Створення списку фірм
        var firms = new List<Firma>
        {
            new Firma { Name = "Food Inc", FoundedDate = DateTime.Now.AddYears(-5), BusinessProfile = "Food", DirectorFullName = "John White", EmployeesCount = 150, Address = "London" },
            new Firma { Name = "Tech Corp", FoundedDate = DateTime.Now.AddYears(-3), BusinessProfile = "IT", DirectorFullName = "Alice Black", EmployeesCount = 120, Address = "London" },
            new Firma { Name = "Marketing Pro", FoundedDate = DateTime.Now.AddYears(-4), BusinessProfile = "Marketing", DirectorFullName = "Bob White", EmployeesCount = 200, Address = "New York" },
            new Firma { Name = "Global Food", FoundedDate = DateTime.Now.AddYears(-6), BusinessProfile = "Food", DirectorFullName = "Charlie Black", EmployeesCount = 80, Address = "Paris" },
        };

        // 1. Отримати інформацію про всі фірми
        var allFirms = firms;
        Console.WriteLine("All Firms:");
        foreach (var firm in allFirms)
        {
            Console.WriteLine($"Name: {firm.Name}, Founded: {firm.FoundedDate.ToShortDateString()}, Profile: {firm.BusinessProfile}");
        }

        // 2. Отримати фірми, у яких у назві є слово "Food"
        var foodFirms = firms.Where(f => f.Name.Contains("Food")).ToList();
        Console.WriteLine("\nFirms with 'Food' in the name:");
        foreach (var firm in foodFirms)
        {
            Console.WriteLine(firm.Name);
        }

        // 3. Отримати фірми, які працюють у галузі маркетингу
        var marketingFirms = firms.Where(f => f.BusinessProfile == "Marketing").ToList();
        Console.WriteLine("\nMarketing Firms:");
        foreach (var firm in marketingFirms)
        {
            Console.WriteLine(firm.Name);
        }

        // 4. Отримати фірми, які працюють у галузі маркетингу або IT
        var marketingOrITFirms = firms.Where(f => f.BusinessProfile == "Marketing" || f.BusinessProfile == "IT").ToList();
        Console.WriteLine("\nMarketing or IT Firms:");
        foreach (var firm in marketingOrITFirms)
        {
            Console.WriteLine(firm.Name);
        }

        // 5. Отримати фірми з кількістю співробітників, більшою за 100
        var largeFirms = firms.Where(f => f.EmployeesCount > 100).ToList();
        Console.WriteLine("\nFirms with more than 100 employees:");
        foreach (var firm in largeFirms)
        {
            Console.WriteLine(firm.Name);
        }

        // 6. Отримати фірми з кількістю співробітників у діапазоні від 100 до 300
        var firmsInRange = firms.Where(f => f.EmployeesCount >= 100 && f.EmployeesCount <= 300).ToList();
        Console.WriteLine("\nFirms with employees between 100 and 300:");
        foreach (var firm in firmsInRange)
        {
            Console.WriteLine(firm.Name);
        }

        // 7. Отримати фірми, які знаходяться в Лондоні
        var londonFirms = firms.Where(f => f.Address == "London").ToList();
        Console.WriteLine("\nFirms in London:");
        foreach (var firm in londonFirms)
        {
            Console.WriteLine(firm.Name);
        }

        // 8. Отримати фірми, у яких прізвище директора White
        var whiteDirectorsFirms = firms.Where(f => f.DirectorFullName.Split(' ').Last() == "White").ToList();
        Console.WriteLine("\nFirms with White as the last name of the director:");
        foreach (var firm in whiteDirectorsFirms)
        {
            Console.WriteLine(firm.Name);
        }

        // 9. Отримати фірми, які засновані більше двох років тому
        var oldFirms = firms.Where(f => (DateTime.Now - f.FoundedDate).TotalDays > 365 * 2).ToList();
        Console.WriteLine("\nFirms founded more than 2 years ago:");
        foreach (var firm in oldFirms)
        {
            Console.WriteLine(firm.Name);
        }

        // 10. Отримати фірми з дня заснування, яких минуло 123 дні
        var firms123Days = firms.Where(f => (DateTime.Now - f.FoundedDate).TotalDays == 123).ToList();
        Console.WriteLine("\nFirms founded 123 days ago:");
        foreach (var firm in firms123Days)
        {
            Console.WriteLine(firm.Name);
        }

        // 11. Отримати фірми, у яких прізвище директора Black і назва фірми містить слово White
        var blackDirectorsWhiteFirms = firms.Where(f => f.DirectorFullName.Split(' ').Last() == "Black" && f.Name.Contains("White")).ToList();
        Console.WriteLine("\nFirms with Black directors and White in the name:");
        foreach (var firm in blackDirectorsWhiteFirms)
        {
            Console.WriteLine(firm.Name);
        }
    }
}

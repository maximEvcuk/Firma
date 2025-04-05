//using System;
//using System.Linq;
//using System.Collections.Generic;

//public class Firma
//{
//    public string Name { get; set; }
//    public DateTime FoundedDate { get; set; }
//    public string BusinessProfile { get; set; }
//    public string DirectorFullName { get; set; }
//    public int EmployeesCount { get; set; }
//    public string Address { get; set; }
//}

//public class Program
//{
//    public static void Main()
//    {
//        var firms = new List<Firma>
//        {
//            new Firma { Name = "Food Inc", FoundedDate = DateTime.Now.AddYears(-5), BusinessProfile = "Food", DirectorFullName = "John White", EmployeesCount = 150, Address = "London" },
//            new Firma { Name = "Tech Corp", FoundedDate = DateTime.Now.AddYears(-3), BusinessProfile = "IT", DirectorFullName = "Alice Black", EmployeesCount = 120, Address = "London" },
//            new Firma { Name = "Marketing Pro", FoundedDate = DateTime.Now.AddYears(-4), BusinessProfile = "Marketing", DirectorFullName = "Bob White", EmployeesCount = 200, Address = "New York" },
//            new Firma { Name = "Global Food", FoundedDate = DateTime.Now.AddYears(-6), BusinessProfile = "Food", DirectorFullName = "Charlie Black", EmployeesCount = 80, Address = "Paris" },
//        };

//        var allFirms = firms;
//        allFirms.ForEach(f => Console.WriteLine($"Name: {f.Name}, Founded: {f.FoundedDate.ToShortDateString()}, Profile: {f.BusinessProfile}"));

//        var foodFirms = firms.Where(f => f.Name.Contains("Food")).ToList();
//        foodFirms.ForEach(f => Console.WriteLine(f.Name));

//        var marketingFirms = firms.Where(f => f.BusinessProfile == "Marketing").ToList();
//        marketingFirms.ForEach(f => Console.WriteLine(f.Name));

//        var marketingOrITFirms = firms.Where(f => f.BusinessProfile == "Marketing" || f.BusinessProfile == "IT").ToList();
//        marketingOrITFirms.ForEach(f => Console.WriteLine(f.Name));

//        var largeFirms = firms.Where(f => f.EmployeesCount > 100).ToList();
//        largeFirms.ForEach(f => Console.WriteLine(f.Name));

//        var firmsInRange = firms.Where(f => f.EmployeesCount >= 100 && f.EmployeesCount <= 300).ToList();
//        firmsInRange.ForEach(f => Console.WriteLine(f.Name));

//        var londonFirms = firms.Where(f => f.Address == "London").ToList();
//        londonFirms.ForEach(f => Console.WriteLine(f.Name));

//        var whiteDirectorsFirms = firms.Where(f => f.DirectorFullName.Split(' ').Last() == "White").ToList();
//        whiteDirectorsFirms.ForEach(f => Console.WriteLine(f.Name));

//        var oldFirms = firms.Where(f => (DateTime.Now - f.FoundedDate).TotalDays > 365 * 2).ToList();
//        oldFirms.ForEach(f => Console.WriteLine(f.Name));

//        var firms123Days = firms.Where(f => (DateTime.Now - f.FoundedDate).TotalDays == 123).ToList();
//        firms123Days.ForEach(f => Console.WriteLine(f.Name));

//        var blackDirectorsWhiteFirms = firms.Where(f => f.DirectorFullName.Split(' ').Last() == "Black" && f.Name.Contains("White")).ToList();
//        blackDirectorsWhiteFirms.ForEach(f => Console.WriteLine(f.Name));
//    }
//}

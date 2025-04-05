//public class Employee
//{
//    public string FullName { get; set; }
//    public string Position { get; set; }
//    public string Phone { get; set; }
//    public string Email { get; set; }
//    public decimal Salary { get; set; }
//}

//public class FirmaWithEmployees : Firma
//{
//    public List<Employee> Employees { get; set; }
//}

//public class Program
//{
//    public static void Main()
//    {
//        // Створення фірм зі співробітниками
//        var firmsWithEmployees = new List<FirmaWithEmployees>
//        {
//            new FirmaWithEmployees
//            {
//                Name = "Tech Corp", Employees = new List<Employee>
//                {
//                    new Employee { FullName = "Lionel Messi", Position = "Manager", Phone = "234567890", Email = "lionel@techcorp.com", Salary = 120000 },
//                    new Employee { FullName = "John Doe", Position = "Developer", Phone = "239876543", Email = "john@techcorp.com", Salary = 90000 }
//                }
//            },
//            new FirmaWithEmployees
//            {
//                Name = "Food Inc", Employees = new List<Employee>
//                {
//                    new Employee { FullName = "Paul Green", Position = "Chef", Phone = "234567891", Email = "paul@foodinc.com", Salary = 70000 }
//                }
//            }
//        };

//        // Отримати всіх співробітників конкретної фірми
//        var techCorpEmployees = firmsWithEmployees.First().Employees;
//        Console.WriteLine("\nEmployees of Tech Corp:");
//        foreach (var employee in techCorpEmployees)
//        {
//            Console.WriteLine(employee.FullName);
//        }

//        // Отримати співробітників з зарплатою більше ніж 100000
//        var highSalaryEmployees = firmsWithEmployees.SelectMany(f => f.Employees).Where(e => e.Salary > 100000).ToList();
//        Console.WriteLine("\nEmployees with salary > 100000:");
//        foreach (var employee in highSalaryEmployees)
//        {
//            Console.WriteLine(employee.FullName);
//        }

//        // Отримати співробітників у всіх фірмах з посадою "Manager"
//        var managers = firmsWithEmployees.SelectMany(f => f.Employees).Where(e => e.Position == "Manager").ToList();
//        Console.WriteLine("\nManagers:");
//        foreach (var manager in managers)
//        {
//            Console.WriteLine(manager.FullName);
//        }

//        // Отримати співробітників, телефон яких починається з "23"
//        var phoneStartsWith23 = firmsWithEmployees.SelectMany(f => f.Employees).Where(e => e.Phone.StartsWith("23")).ToList();
//        Console.WriteLine("\nEmployees whose phone starts with '23':");
//        foreach (var employee in phoneStartsWith23)
//        {
//            Console.WriteLine(employee.FullName);
//        }

//        // Отримати співробітників, Email яких починається з "di"
//        var emailStartsWithDI = firmsWithEmployees.SelectMany(f => f.Employees).Where(e => e.Email.StartsWith("di")).ToList();
//        Console.WriteLine("\nEmployees whose email starts with 'di':");
//        foreach (var employee in emailStartsWithDI)
//        {
//            Console.WriteLine(employee.FullName);
//        }

//        // Отримати співробітників, ім'я яких Lionel
//        var lionelEmployees = firmsWithEmployees.SelectMany(f => f.Employees).Where(e => e.FullName.Contains("Lionel")).ToList();
//        Console.WriteLine("\nEmployees with name Lionel:");
//        foreach (var employee in lionelEmployees)
//        {
//            Console.WriteLine(employee.FullName);
//        }
//    }
//}

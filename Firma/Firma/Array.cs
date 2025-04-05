//using System;
//public class Program
//{
//    public static void Main()
//    {
//        var numbers = new List<int> { 121, 75, 81 };

//        var sortedNumbersAsc = numbers.OrderBy(n => SumOfDigits(n)).ToList();
//        Console.WriteLine("Sorted Ascending:");
//        foreach (var num in sortedNumbersAsc)
//            Console.WriteLine(num);

//        var sortedNumbersDesc = numbers.OrderByDescending(n => SumOfDigits(n)).ToList();
//        Console.WriteLine("Sorted Descending:");
//        foreach (var num in sortedNumbersDesc)
//            Console.WriteLine(num);
//    }

//    public static int SumOfDigits(int number)
//    {
//        return number.ToString().Select(c => c - '0').Sum();
//    }
//}

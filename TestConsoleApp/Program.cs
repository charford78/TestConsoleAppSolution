using System;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("To the C# World...");

            int NumberOfStudents = 17;
            var TotalInClass = NumberOfStudents + 2;
            Console.WriteLine($"Number of students is {NumberOfStudents}, total is {TotalInClass}");
            var MyName = "Charlie";
            Console.WriteLine($"{MyName} is one of the {NumberOfStudents} students in the class.");
            Console.WriteLine($"There are {TotalInClass - NumberOfStudents} in the class that are not students.");
        }
    }
}

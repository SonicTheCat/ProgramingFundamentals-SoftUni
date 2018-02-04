namespace _03.EmployeeData
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employeeID = int.Parse(Console.ReadLine());
            decimal montlySalary = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {employeeID:D8}");
            Console.WriteLine($"Salary: {montlySalary:F2}");
        }
    }
}

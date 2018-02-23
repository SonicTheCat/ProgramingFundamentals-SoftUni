namespace _04.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> studDict = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                Student newStudent = new Student();
                newStudent.Name = input[0];
                var count = 0;
                for (int j = 1; j < input.Length; j++)
                {
                    newStudent.Grades += double.Parse(input[j]);
                    count++;
                }
                newStudent.Grades = newStudent.Grades / count;
                studDict.Add(newStudent);

            }
            foreach (var student in studDict.OrderBy(x => x.Name).ThenByDescending(x => x.Grades))
            {
                if (student.Grades >= 5.00)
                {
                    Console.WriteLine($"{student.Name} -> {student.Grades:F2}");
                }
            }
        }
    }
    class Student
    {
   
        public string Name { get; set; }
        public double Grades { get; set; }
    }
}

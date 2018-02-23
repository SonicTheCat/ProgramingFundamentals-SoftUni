namespace _04._02AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> exellentGradeStuds = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                Student currentStud = new Student();
                currentStud.Name = input[0];
                input.RemoveAt(0);
                currentStud.Grade = input.Select(double.Parse).ToList();
                exellentGradeStuds.Add(currentStud);
            }
            foreach (var student in exellentGradeStuds
               .Where(g=>g.AverageGrades>=5).OrderBy(x=>x.Name).ThenByDescending(x=>x.AverageGrades))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrades:F2}");
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<double> Grade = new List<double>();
        public double AverageGrades { get {return Grade.Average(); } }
    }
}

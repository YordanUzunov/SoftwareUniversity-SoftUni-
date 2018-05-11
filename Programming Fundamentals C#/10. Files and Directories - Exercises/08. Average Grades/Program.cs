namespace _08._Average_Grades
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<Student> students = GatherstudentData();
            students = students
                .Where(x => x.AvarageGrade >= 5)
                .OrderBy(x => x.Name)
                .ThenBy(x => -x.AvarageGrade)
                .ToList();

            StudentsToFile(students);
        }

        private static void StudentsToFile(List<Student> students)
        {
            File.WriteAllLines("../../../IO/StudentsWithAvgGradeAbove5.txt", students.Select(x => $"{x.Name} -> {x.AvarageGrade:F2}").ToList());
        }

        private static List<Student> GatherstudentData()
        {
            string[] studentGrades = File.ReadAllLines("../../../IO/input.txt");
            List<Student> students = new List<Student>();

            for (int i = 0; i < studentGrades.Length; i++)
            {
                string[] currentStudent = studentGrades[i].Split(' ');
                string name = currentStudent[0];
                List<float> grades = currentStudent.Skip(1).Select(float.Parse).ToList();

                students.Add(new Student { Name = name, Grades = grades });
            }

            return students;
        }
    }
}

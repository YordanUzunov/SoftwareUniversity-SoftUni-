namespace _04._Average_Grades
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Student[] students = GetStudentArray();
            PrintBestStudents(students);
        }

        private static void PrintBestStudents(Student[] students)
        {
            Student[] bestStudents = students
                .OrderBy(x => x.Name)
                .ThenBy(x => -x.AvarageGrade)
                .Where(x => x.AvarageGrade >= 5)
                .ToArray();

            foreach (Student student in bestStudents)
            {
                Console.WriteLine($"{student.Name} -> {student.AvarageGrade:F2}");
            }
        }

        private static Student[] GetStudentArray()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            Student[] students = new Student[numberOfStudents];
            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentData = Console.ReadLine().Split(' ');
                int j = 0;
                students[i] = new Student();
                while (!char.IsDigit(studentData[j][0]))
                {
                    if (j == 0)
                    {
                        students[i].Name = studentData[j];
                    }
                    else
                    {
                        students[i].Name += " " + studentData[j];
                    }

                    j++;
                }

                students[i].Grades = studentData
                    .Skip(j)
                    .Select(double.Parse)
                    .ToList();
            }

            return students;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using _01.ClassStudent;
//Print all students from group number 2. Use a LINQ query. Order the students by FirstName
namespace _02.StudentsByGroup
{
    class StudentsByGroup
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students = Student.FillStudents();

            List<Student> grouped = students.Where(x => x.GroupNumber == 2).OrderBy(x => x.FirstName).ToList();
            Print(grouped);
        }

        public static void Print(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}", string.Concat(student.FirstName, " ", student.LastName));
                Console.WriteLine("Age: {0}", student.Age);
                Console.WriteLine("Faculty number: {0}", student.FacultyNumber);
                Console.WriteLine("E-mail: {0}", student.Email);
                Console.WriteLine("Group number: {0}", student.GroupNumber);
                Console.WriteLine("Phone number: {0}", student.Phone);
                Console.WriteLine(new String('-', 20));
            }
        }
    }
}

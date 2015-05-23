using System;
using System.Collections.Generic;
using System.Linq;
using _01.ClassStudent;
//Print all students with phones in Sofia (starting with 02 / +3592 / +359 2). Use LINQ
namespace _07.FilterStudentsByPhone
{
    class FilterStudentsByPhone
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students = Student.FillStudents();

            var filtered = students.Where(x => x.Phone.StartsWith("02") || x.Phone.StartsWith("+3592") || x.Phone.StartsWith("+359 2")).ToList();
            Print(filtered);
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

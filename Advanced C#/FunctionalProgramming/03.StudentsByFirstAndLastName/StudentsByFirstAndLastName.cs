using System;
using System.Collections.Generic;
using System.Linq;
using _01.ClassStudent;
//Print all students whose first name is before their last name alphabetically. Use a LINQ query
namespace _03.StudentsByFirstAndLastName
{
    class StudentsByFirstAndLastName
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students = Student.FillStudents();
            List<Student> compared = students.Where(x => x.FirstName.CompareTo(x.LastName) == -1).ToList();
            Print(compared);
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

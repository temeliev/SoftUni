using System;
using System.Collections.Generic;

//Create a class Student with properties FirstName, LastName, Age, FacultyNumber, Phone, Email, Marks (IList<int>), GroupNumber. 
//Create a List<Student> with sample students. 
//These students will be used for the next few tasks.
namespace _01.ClassStudent
{
    class ClassStudent
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students = Student.FillStudents();
            Print(students);
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

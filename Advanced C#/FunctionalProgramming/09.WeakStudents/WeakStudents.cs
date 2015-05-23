using System;
using System.Collections.Generic;
using _01.ClassStudent;
//Write a similar program to the previous one to extract the students with exactly two marks "2". 
namespace _09.WeakStudents
{
    class WeakStudents
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students = Student.FillStudents();

            var weakStudents = students.WeakStudents();

            foreach (var b in weakStudents)
            {
                Console.WriteLine("Full Name: {0}", string.Concat(b.FirstName, " ", b.LastName));
                Console.WriteLine("Marks: ( {0} )", string.Join(", ", b.Marks));
                Console.WriteLine(new String('-', 20));
            }
        }
    }
}

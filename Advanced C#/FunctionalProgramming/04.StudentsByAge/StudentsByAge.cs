using System;
using System.Collections.Generic;
using System.Linq;
using _01.ClassStudent;
//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. The query should return only the first name, last name and age
namespace _04.StudentsByAge
{
    class StudentsByAge
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students = Student.FillStudents();

            var result = from t in students
                         where t.Age >= 18 && t.Age <= 24
                         select new Student()
                         {
                             FirstName = t.FirstName,
                             LastName = t.LastName,
                             Age = t.Age
                         };


            foreach (var student in result)
            {
                Console.WriteLine("Name: {0}", string.Concat(student.FirstName, " ", student.LastName));
                Console.WriteLine("Age: {0}", student.Age);
            }
        }
    }
}

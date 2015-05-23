using System;
using System.Collections.Generic;
using System.Linq;
using _01.ClassStudent;
//Print all students that have at least one mark Excellent (6). Using LINQ first select them into a new anonymous class that holds { FullName + Marks}.
namespace _08.ExcellentStudents
{
    class ExcellentStudents
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students = Student.FillStudents();

            var best = from t in students
                       where t.Marks.Contains(6)
                       select new
                       {
                           FullName = t.FirstName + " " + t.LastName,
                           Marks = " (" + string.Join(", ", t.Marks) + " )"
                       };

            foreach (var b in best)
            {
                Console.WriteLine("Full Name: {0}", b.FullName);
                Console.WriteLine("Marks: {0}", b.Marks);
                Console.WriteLine(new String('-', 20));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using _01.ClassStudent;

//Add a GroupName property to Student. 
//Write a program that extracts all students grouped by GroupName and then prints them on the console. 
//Print all group names along with the students in each group. Use the "group by into" LINQ operator.
namespace _11.StudentsByGroups
{
    class StudentsByGroups
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students = Student.FillStudents();
            var grouped = from t in students
                          group t by t.GroupName;

            // var test = students.GroupBy(x => x.GroupName).ToList();

            foreach (var gr in grouped)
            {
                Console.WriteLine(gr.Key);
                Print(gr.ToList());
            }
        }

        public static void Print(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(" Name: {0}", string.Concat(student.FirstName, " ", student.LastName));
                Console.WriteLine(" Age: {0}", student.Age);
                Console.WriteLine(" Faculty number: {0}", student.FacultyNumber);
                Console.WriteLine(" E-mail: {0}", student.Email);
                Console.WriteLine(" Group number: {0}", student.GroupNumber);
                Console.WriteLine(" Phone number: {0}", student.Phone);
                Console.WriteLine(new String('-', 20));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using _01.ClassStudent;
//Extract and print the Marks of the students that enrolled in 2014 (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber).
namespace _10.StudentsEnrolledIn2014
{
    class StudentsEnrolledIn2014
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students = Student.FillStudents();

            var marks = students.Where(x => x.FacultyNumber[4] == '1' && x.FacultyNumber[5] == '4').Select(x => x.Marks).ToList();
            marks.ForEach(x => Console.WriteLine(string.Join(", ", x)));
        }
    }
}

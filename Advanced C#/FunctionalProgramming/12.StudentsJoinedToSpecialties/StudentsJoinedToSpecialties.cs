using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using _01.ClassStudent;

//Create a class StudentSpecialty that holds specialty name and faculty number. 
//Create a list of student specialties, where each specialty corresponds to a certain student (via the faculty number). 
//Print all student names alphabetically along with their faculty number and specialty name. 
//Use the "join" LINQ operator. 
namespace _12.StudentsJoinedToSpecialties
{
    class StudentsJoinedToSpecialties
    {
        static void Main()
        {
            List<StudentSpecialty> specialties = new List<StudentSpecialty>()
            {
                new StudentSpecialty("Web Developer", "12341356"),
                new StudentSpecialty("Web Developer", "12341557"),
                new StudentSpecialty("Web Developer", "12341560"),
                new StudentSpecialty("PHP Developer", "12341358"),
                new StudentSpecialty("PHP Developer", "12341559"),
                new StudentSpecialty("QA Engineer", "12341461"),
                new StudentSpecialty("Web Developer", "12341467")
            };

            List<Student> students = new List<Student>();
            students = Student.FillStudents();

            var joined = from s in specialties
                         join t in students on s.FacultyNumber equals t.FacultyNumber
                         orderby t.FirstName, t.LastName
                         select new
                         {
                             FullName = string.Concat(t.FirstName, " ", t.LastName),
                             FacultyNum = t.FacultyNumber,
                             Specialty = s.SpecialtyName
                         };

            foreach (var item in joined)
            {
                Console.WriteLine("Name: {0}", item.FullName);
                Console.WriteLine("Faculty number: {0}", item.FacultyNum);
                Console.WriteLine("Specialty: {0}", item.Specialty);
                Console.WriteLine(new String('-', 20));
            }
        }
    }
}

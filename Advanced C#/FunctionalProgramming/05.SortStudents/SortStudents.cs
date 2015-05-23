using System.Collections.Generic;
using System.Linq;
using _01.ClassStudent;
//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. 
//Rewrite the same with LINQ query syntax.
namespace _05.SortStudents
{
    class SortStudents
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students = Student.FillStudents();

            var sortedList1 = (from t in students
                               orderby t.FirstName descending, t.LastName 
                               select new Student()
                               {
                                   FirstName = t.FirstName,
                                   LastName = t.LastName,
                                   Age = t.Age,
                                   Email = t.Email,
                                   FacultyNumber = t.FacultyNumber,
                                   GroupNumber = t.GroupNumber,
                                   Phone = t.Phone,
                                   Marks = t.Marks
                               }).ToList();

            var sortedList2 = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName).ToList();
        }
    }
}

using System.Collections.Generic;

namespace _01.ClassStudent
{
    public class Student
    {
        public Student()
        {
            Marks = new List<int>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int GroupNumber { get; set; }
        public string GroupName { get; set; }
        public List<int> Marks { get; set; }

        public static List<Student> FillStudents()
        {
            List<Student> students = new List<Student>();
            Student student1 = new Student();
            student1.FirstName = "Petkan";
            student1.LastName = "Petkanov";
            student1.Age = 18;
            student1.FacultyNumber = "12341356";
            student1.Email = "petkan@abv.bg";
            student1.GroupNumber = 1;
            student1.GroupName = "Group A";
            student1.Phone = "+359 89999";
            student1.Marks.Add(4);
            student1.Marks.Add(5);
            student1.Marks.Add(2);
            student1.Marks.Add(6);
            students.Add(student1);

            Student student2 = new Student();
            student2.FirstName = "Ivan";
            student2.LastName = "Geshev";
            student2.Age = 21;
            student2.FacultyNumber = "12341557";
            student2.Email = "ivan@abv.bg";
            student2.GroupNumber = 2;
            student2.GroupName = "Group B";
            student2.Phone = "+359 12345";
            student2.Marks.Add(3);
            student2.Marks.Add(3);
            student2.Marks.Add(3);
            student2.Marks.Add(6);
            students.Add(student2);

            Student student5 = new Student();
            student5.FirstName = "Kiro";
            student5.LastName = "Trendafilov";
            student5.Age = 18;
            student5.FacultyNumber = "12341560";
            student5.Email = "kiro@abv.bg";
            student5.GroupNumber = 2;
            student5.GroupName = "Group B";
            student5.Phone = "+3592 11111";
            student5.Marks.Add(2);
            student5.Marks.Add(2);
            student5.Marks.Add(4);
            student5.Marks.Add(4);
            students.Add(student5);

            Student student3 = new Student();
            student3.FirstName = "Maria";
            student3.LastName = "Poleva";
            student3.Age = 22;
            student3.FacultyNumber = "12341358";
            student3.Email = "maria@gmail.bg";
            student3.GroupNumber = 3;
            student3.GroupName = "Group C";
            student3.Phone = "+359 29999";
            student3.Marks.Add(5);
            student3.Marks.Add(5);
            student3.Marks.Add(3);
            student3.Marks.Add(4);
            students.Add(student3);

            Student student4 = new Student();
            student4.FirstName = "Yanka";
            student4.LastName = "Jekova";
            student4.Age = 20;
            student4.FacultyNumber = "12341559";
            student4.Email = "yanka@yahoo.com";
            student4.GroupNumber = 3;
            student4.GroupName = "Group C";
            student4.Phone = "056 56777";
            student4.Marks.Add(6);
            student4.Marks.Add(6);
            student4.Marks.Add(6);
            student4.Marks.Add(4);
            students.Add(student4);

            Student student6 = new Student();
            student6.FirstName = "Arpadjik";
            student6.LastName = "Valentinova";
            student6.Age = 26;
            student6.FacultyNumber = "12341461";
            student6.Email = "arpa@abv.bg";
            student6.GroupNumber = 2;
            student6.GroupName = "Group B";
            student6.Phone = "02 0909089999";
            student6.Marks.Add(5);
            student6.Marks.Add(5);
            student6.Marks.Add(5);
            student6.Marks.Add(5);
            students.Add(student6);

            Student student7 = new Student();
            student7.FirstName = "Valentin";
            student7.LastName = "Arhangelov";
            student7.Age = 32;
            student7.FacultyNumber = "12341467";
            student7.Email = "value@abv.bg";
            student7.GroupNumber = 1;
            student7.GroupName = "Group A";
            student7.Phone = "056 0909089999";
            student7.Marks.Add(6);
            student7.Marks.Add(6);
            student7.Marks.Add(6);
            student7.Marks.Add(6);
            students.Add(student7);

            return students;
        }
    }
}

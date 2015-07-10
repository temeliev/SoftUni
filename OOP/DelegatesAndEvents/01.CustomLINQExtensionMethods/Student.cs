namespace _01.CustomLINQExtensionMethods
{
    public class Student
    {
        public Student(string name, int grade)
        {
            this.Name = name;
            this.Grade = grade;
        }

        public string Name { get; set; }

        public int Grade { get; set; }
    }
}

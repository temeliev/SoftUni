using System;
using System.Text;

namespace _01.HumanStudentAndWorker
{
    public class Student : Human
    {
        private string facultyNumber;
        public Student(string facultyNumber, string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return facultyNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Faculty number is missing!");
                }

                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("The faculty number should be in range[5-10] characters!");
                }

                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Faculty number: {0}\n{1}", this.FacultyNumber, new String('-', 20)); //"First name: {0}\nLast name: {1}\n
        }
    }
}

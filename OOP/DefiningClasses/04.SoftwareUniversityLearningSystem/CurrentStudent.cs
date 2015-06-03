using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    public class CurrentStudent : Student
    {
        private string currentCourse;

        public string CurrentCourse
        {
            get { return currentCourse; }

            set
            {
                currentCourse = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Student name: {0}", string.Concat(base.FirstName, " ", base.LastName)));
            sb.AppendLine(string.Format("Age: {0}", base.Age));
            sb.AppendLine(string.Format("Number: {0}", base.Number));
            sb.AppendLine(string.Format("Average grade: {0}", base.AverageGrade));
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    public class Student : Person
    {
        private uint number;
        public uint Number
        {
            get { return number; }
            set
            {
                number = value;
            }
        }

        private double averageGrade;
        public double AverageGrade
        {
            get { return averageGrade; }
            set
            {
                averageGrade = value;
            }
        }
    }
}

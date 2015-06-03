using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    public class SeniorTrainer : Trainer
    {
        public void DeleteCourse(string courseName)
        {
            Console.WriteLine("{0} has been deleted!", courseName);
        }
    }
}

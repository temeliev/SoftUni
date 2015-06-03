using System;

namespace _04.SoftwareUniversityLearningSystem
{
    public class Trainer : Person
    {
        public void CreateCourse(string courseName)
        {
            Console.WriteLine("{0} has been created!", courseName);
        }
    }
}

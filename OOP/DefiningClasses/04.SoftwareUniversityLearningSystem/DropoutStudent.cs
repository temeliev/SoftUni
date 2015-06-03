using System;

namespace _04.SoftwareUniversityLearningSystem
{
    public class DropoutStudent : Student
    {
        private string dropOutReason;

        public string DropOutReason
        {
            get { return dropOutReason; }

            set
            {
                dropOutReason = value;
            }
        }

        public void Reapply()
        {
            Console.WriteLine("Student name: {0}", string.Concat(base.FirstName, " ", base.LastName));
            Console.WriteLine("Age: {0}", base.Age);
            Console.WriteLine("Number: {0}", base.Number);
            Console.WriteLine("Average grade: {0}", base.AverageGrade);
            Console.WriteLine("Dropout reason: {0}", this.DropOutReason);
        }
    }
}

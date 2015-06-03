using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    class SoftwareUniversityLearningSystem
    {
        static void Main()
        {
            SULSTest test = new SULSTest();

            List<CurrentStudent> currentStudents = test.Objects.Where(x => x.GetType() == typeof(CurrentStudent)).Cast<CurrentStudent>().ToList();

            foreach (var item in currentStudents.OrderBy(x => x.AverageGrade))
            {
                Console.WriteLine(item);
            }
        }
    }
}

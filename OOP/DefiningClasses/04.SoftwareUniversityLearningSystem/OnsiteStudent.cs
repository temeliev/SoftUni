using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    public class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;

        public int NumberOfVisits
        {
            get { return numberOfVisits; }
            set
            {
                numberOfVisits = value;
            }
        }
    }
}

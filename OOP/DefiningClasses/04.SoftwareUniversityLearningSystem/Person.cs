using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    public class Person
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Empty name!");
                }

                firstName = value;
            }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Empty last name!");
                }

                lastName = value;
            }
        }

        private byte age;
        public byte Age
        {
            get { return age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Wrong age!");
                }

                age = value;
            }
        }
    }
}

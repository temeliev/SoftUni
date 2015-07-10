using System;

namespace _02.Animals
{
    public abstract class Animal
    {
        private string name;
        private byte age;
        private string gender;

        public Animal(string name, byte age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The name is missing!");
                }

                name = value;
            }
        }

        public byte Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 30)
                {
                    throw new ArgumentOutOfRangeException("The age should be in range 1-30!");
                }

                age = value;
            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The gender is missing!");
                }

                if (value != "male" && value != "female")
                {
                    throw new ArgumentException("The gender is misspelled!");
                }

                gender = value;
            }
        }
    }
}

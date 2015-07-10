using System;

namespace _03.CompanyHierarchy
{
    public abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        public Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The id is negative!");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The first name is missing!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The last name is missing!");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("ID: {0}\nName: {1}\n", this.Id, string.Concat(this.FirstName, " ", this.LastName));
        }
    }
}

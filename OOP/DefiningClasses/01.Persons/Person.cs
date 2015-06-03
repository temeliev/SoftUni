using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Person
    {
        public Person(string name, byte age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, byte age)
            : this(name, age, null)
        {
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Empty name!");
                }

                name = value;
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

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (value == null || value.Contains('@'))
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("Wrong email!");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}\nE-mail: {2}", this.Name, this.Age, this.Email ?? "none");
        }
    }
}

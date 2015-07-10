namespace _04.StudentClass
{
    using System;

    public class Student
    {
        private string name;

        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The name is missing!");
                }

                var eventArgs = new CustomEventArgs(this.name, value, "Name");
                this.name = value;

                if (this.OnProperyChanged != null)
                {
                    this.OnProperyChanged(this.name, eventArgs);
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The age cannot be negative!");
                }

                var eventArgs = new CustomEventArgs(this.age.ToString(), value.ToString(), "Age");
                this.age = value;

                if (this.OnProperyChanged != null)
                {
                    this.OnProperyChanged(this.age, eventArgs);
                }
            }
        }

        public event EventHandler OnProperyChanged;

        public delegate void EventHandler(object sender, CustomEventArgs e);

    }
}

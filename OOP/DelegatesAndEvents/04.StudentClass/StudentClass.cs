namespace _04.StudentClass
{
    using System;

    class StudentClass
    {
        static void Main()
        {
            Student student = new Student("Peter", 22);
            student.OnProperyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    eventArgs.PropertyName, eventArgs.OldValue, eventArgs.NewValue);
            };

            student.Name = "Maria";
            student.Age = 19;

        }
    }
}

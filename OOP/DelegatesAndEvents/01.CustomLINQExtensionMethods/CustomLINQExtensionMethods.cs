namespace _01.CustomLINQExtensionMethods
{
    using System;
    using System.Collections.Generic;
    
    class CustomLinqExtensionMethods
    {
        static void Main()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var filteredColletion = list.WhereNot(x => x % 2 == 0);
            Console.WriteLine(string.Join(", ", filteredColletion));

            List<Student> students = new List<Student>()
            {
                new Student("Pesho", 3),
                new Student("Gosho", 2),
                new Student("Mariika", 7),
                new Student("Stamat", 5)
            };

            Console.WriteLine(students.MaxItem(st => st.Grade));
        }
    }
}

using System;

namespace Persons
{
    class MainClass
    {
        static void Main()
        {
            Person person1 = new Person("Ivan", 21);
            Console.WriteLine(person1);
            Person person2 = new Person("Penka", 51, "penka@abv.bg");
            Console.WriteLine(person2);
        }
    }
}

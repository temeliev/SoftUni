using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Animals
{
    class Animals
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>();
            Cat cat1 = new Kitten("Pisi", 5);
            Cat cat2 = new TomCat("Tom", 5);
            Dog dog1 = new Dog("Sharo", 2, "male");
            Dog dog2 = new Dog("Misho", 4, "male");
            Frog frog = new Frog("Java", 7, "female");

            animals.Add(cat1);
            animals.Add(cat2);
            animals.Add(dog1);
            animals.Add(dog2);
            animals.Add(frog);

            double avg = animals.Sum(x => (double)x.Age) / animals.Count;
            Console.WriteLine("Average age: {0}", avg);
        }
    }
}

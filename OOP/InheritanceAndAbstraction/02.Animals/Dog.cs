
using System;

namespace _02.Animals
{
    public class Dog : Animal, ISoundProducible
    {
        public Dog(string name, byte age, string gender) : base(name, age, gender) { }

        public void ProduceSound()
        {
            Console.WriteLine("Bauuu!");
        }
    }
}

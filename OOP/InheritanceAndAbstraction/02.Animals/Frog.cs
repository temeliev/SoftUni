using System;

namespace _02.Animals
{
    public class Frog : Animal, ISoundProducible
    {
        public Frog(string name, byte age, string gender) : base(name, age, gender) { }

        public void ProduceSound()
        {
            Console.WriteLine("Kwak");
        }
    }
}

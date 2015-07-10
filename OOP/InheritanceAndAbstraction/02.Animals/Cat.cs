using System;
namespace _02.Animals
{
    public abstract class Cat : Animal, ISoundProducible
    {
        public Cat(string name, byte age, string gender) : base(name, age, gender) { }

        public void ProduceSound()
        {
            Console.WriteLine("Myauu!");
        }
    }
}

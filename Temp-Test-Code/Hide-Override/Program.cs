using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_Override
{
    class Program
    {
        static void Main()
        {
            Animal animal = new Dog();
            animal.GetName();
            animal.MakeSound();

            Console.WriteLine("----");

            Dog dog = new Dog();
            dog.GetName();
            dog.MakeSound();

            Console.ReadKey();
        }
    }

    class Animal
    {
        public void GetName()
        {
            Console.WriteLine("I'm an animal");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("boooo");
        }
    }

    class Dog : Animal
    {
        public new void GetName()
        {
            Console.WriteLine("I'm a dog");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hrrrragh");
        }
    }
}


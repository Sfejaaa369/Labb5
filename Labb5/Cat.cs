using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Labb5
{
    internal class Cat : Animal
    {
        //property for cat
        public bool LongHair { get; set; } = true;

        //konstruktor
        public Cat(string name, int age, string colour, double weight, string health) : base(name, age, colour, weight, health)
        {

        }

        //method for cats
        public void Scratch()
        {
            Console.WriteLine($"{Name} likes scratching on the scratching pole.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}

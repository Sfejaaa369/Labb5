using System;
using System.Collections.Generic;
using System.Text;

namespace Labb5
{
    internal class Tiger : Animal
    {
        //property for tiger
        public int Strength { get; set; } = 100;

        //konstruktor
        public Tiger(string name, int age, string colour, double weight, string health) : base(name, age, colour, weight, health)
        {

        }

        //method for tiger
        public void Hunt()
        {
            Console.WriteLine($"{Name} likes to hunt.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Rawr!");
        }

    }
}

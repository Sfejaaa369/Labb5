using System;
using System.Collections.Generic;
using System.Text;

namespace Labb5
{
    internal class RescueCat : Cat
    {
        //property for rescue cats
        public bool Adopted { get; set; } = false;

        //konstruktor
        public RescueCat(string name, int age, string colour, double weight, string health) : base(name, age, colour, weight, health)
        {

        }

        //method for Rescue cat
        public void Cuddle()
        {
            Console.WriteLine($"{Name} loooooves to cuddle.");
        }
    }
}

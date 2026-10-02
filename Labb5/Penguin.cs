using System;
using System.Collections.Generic;
using System.Text;

namespace Labb5
{
    internal class Penguin : Animal
    {
        //property for penguin
        public string OriginCountry { get; set; } = "Sweden";

        //konstruktor
        public Penguin(string name, int age, string colour, double weight, string health) : base(name, age, colour, weight, health)
        {

        }

        //method for penguin
        public void Swim()
        {
            Console.WriteLine($"{Name} likes swimming.");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Chirp chirp!");
        }
    }
}

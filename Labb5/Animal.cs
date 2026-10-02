using System;
using System.Collections.Generic;
using System.Text;

namespace Labb5
{
    internal abstract class Animal
    {
        //5 properties that all animals have in common
        public string Name { get; set; } = "Unknown";
        public int Age { get; set; } = 0;
        public string Colour { get; set; } = "green";
        public double Weight { get; set; } = 5.5;
        public string Health { get; set; } = "healthy";

        //konstruktor to create a new animal
        public Animal(string name, int age, string colour, double weight, string health)
        {
            Name = name;
            Age = age;
            Colour = colour;
            Weight = weight;
            Health = health;
        }

        //3 methods that all animals have in common
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }

        public abstract void MakeSound(); //abstract method for MakeSound

    }
}

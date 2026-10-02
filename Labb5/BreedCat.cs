using System;
using System.Collections.Generic;
using System.Text;

namespace Labb5
{
    internal class BreedCat : Cat
    {
        //property for Breed cat
        public string FavouriteToy { get; set; } = "ball";

        //konstruktor
        public BreedCat(string name, int age, string colour, double weight, string health) : base(name, age, colour, weight, health)
        {

        }

        //method for Breed cat
        public void GetsZoomies()
        {
            Console.WriteLine($"{Name} sometimes gets the zoomies and runs around like crazy!");
        }
    }
}

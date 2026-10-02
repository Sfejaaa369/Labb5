namespace Labb5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cat
            Cat cat1 = new Cat("Sofia", 3, "green", 4.6, "healthy");
            Console.WriteLine($"Tada, the cat {cat1.Name} is here. They weigh {cat1.Weight}kg and are {cat1.Health}");
            cat1.MakeSound();
            cat1.Scratch();
            Console.WriteLine("\n-----\n");

            //rescue cat
            RescueCat rescuecat1 = new RescueCat("Mia", 13, "grey", 6, "healthy");
            Console.WriteLine($"The rescue cat {rescuecat1.Name} is {rescuecat1.Age} years old and is {rescuecat1.Health}.");
            rescuecat1.MakeSound();
            rescuecat1.Cuddle();
            Console.WriteLine("\n-----\n");

            //breed cat
            BreedCat breedcat1 = new BreedCat("Karen", 1, "grey", 4, "unhealthy");
            Console.WriteLine($"{breedcat1.Name} is a breed cat. They weight {breedcat1.Weight}kg and are {breedcat1.Health}.");
            breedcat1.MakeSound();
            breedcat1.GetsZoomies();
            Console.WriteLine("\n-----\n");

            //penguin
            Penguin penguin1 = new Penguin("Joseph", 6, "black and white", 25, "healthy");
            Console.WriteLine($"The penguin {penguin1.Name} has arrived. They weigh {penguin1.Weight}kg and are {penguin1.Health}!");
            penguin1.MakeSound();
            penguin1.Swim();
            Console.WriteLine("\n-----\n");

            //tiger
            Tiger tiger1 = new Tiger("Johnny", 9, "orange", 75, "a bit fat but healthy");
            Console.WriteLine($"The tiger {tiger1.Name} is here and they weigh {tiger1.Weight}kg. Their health status: {tiger1.Health}.");
            tiger1.MakeSound();
            tiger1.Hunt();


        }
    }
}

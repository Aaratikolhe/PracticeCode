using System;

namespace OopConceptPractice
{
    class Program
    {
        static void Main(String[] args)
        {
            Dog Spot = new Dog();
            Spot.Color = "White";
            Spot.Breed = "german Shephard";
            Console.WriteLine("Dog color: "+Spot.Color);
            Console.WriteLine("Dog breed: " + Spot.Breed);
            Spot.MakeNoise();
            Spot.Move();
            
            Animal animal = new Animal();
            animal.MakeNoise();


        }
        

    }
}

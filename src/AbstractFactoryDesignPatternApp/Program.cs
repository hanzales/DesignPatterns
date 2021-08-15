using System;
using AbstractFactoryDesignPatternApp.Factories;
using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = null;
            AnimalFactory animalFactory = null;
            var speakSound = string.Empty;

            animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine("Animal factory type: " + animalFactory.GetType().Name);

            animal = animalFactory.GetAnimal("Octopus");
            Console.WriteLine("Animal Type: " + animal.GetType().Name);

            speakSound = animal.Speak();

            Console.ReadLine();
        }
    }
}

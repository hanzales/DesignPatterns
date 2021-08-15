using AbstractFactoryDesignPatternApp.Interfaces;
using AbstractFactoryDesignPatternApp.Models;

namespace AbstractFactoryDesignPatternApp.Factories
{
    public class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string animalType)
        {
            return animalType switch
            {
                "Dog" => new Dog(),
                "Cat" => new Cat(),
                "Lion" => new Lion(),
                _ => null
            };
        }
    }
}
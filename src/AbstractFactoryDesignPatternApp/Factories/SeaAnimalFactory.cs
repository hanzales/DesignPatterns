using AbstractFactoryDesignPatternApp.Interfaces;
using AbstractFactoryDesignPatternApp.Models;

namespace AbstractFactoryDesignPatternApp.Factories
{
    public class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string animalType)
        {
            return animalType switch
            {
                "Shark" => new Shark(),
                "Octopus" => new Octopus(),
                _ => null
            };
        }
    }
}
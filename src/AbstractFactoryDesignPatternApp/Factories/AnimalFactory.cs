using AbstractFactoryDesignPatternApp.Interfaces;
using AbstractFactoryDesignPatternApp.Models;

namespace AbstractFactoryDesignPatternApp.Factories
{
    public abstract class AnimalFactory
    {
        public abstract Animal GetAnimal(string animalType);

        public static AnimalFactory CreateAnimalFactory(string factoryType)
        {
            if (factoryType.Equals("Sea"))
                return new SeaAnimalFactory();

            return new LandAnimalFactory();
        }
    }
}
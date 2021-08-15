using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp.Factories
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string animalType);

        public static AnimalFactory CreateAnimalFactory(string factoryType)
        {
            if (factoryType.Equals("Sea"))
                return new SeaAnimalFactory();

            return new LandAnimalFactory();
        }
    }
}
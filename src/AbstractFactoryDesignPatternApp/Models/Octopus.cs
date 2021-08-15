using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp.Models
{
    public class Octopus : IAnimal
    {
        public string Speak()
        {
            return "SQUAWCK";
        }
    }
}
using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp.Models
{
    public class Octopus : Animal
    {
        public string Speak()
        {
            return "SQUAWCK";
        }
    }
}
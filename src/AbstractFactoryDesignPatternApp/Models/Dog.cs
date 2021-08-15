using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp.Models
{
    public class Dog : IAnimal
    {
        public string Speak()
        {
            return "Haw";
        }
    }
}
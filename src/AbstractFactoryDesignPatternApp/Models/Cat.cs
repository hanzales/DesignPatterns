using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp.Models
{
    public class Cat : IAnimal
    {
        public string Speak()
        {
            return "Meow";
        }
    }
}
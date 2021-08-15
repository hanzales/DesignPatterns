using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp.Models
{
    public class Shark : IAnimal
    {
        public string Speak()
        {
            return "Cannot speak";
        }
    }
}
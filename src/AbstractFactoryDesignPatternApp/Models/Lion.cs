using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp.Models
{
    public class Lion : IAnimal
    {
        public string Speak()
        {
            return "Roar";
        }
    }
}
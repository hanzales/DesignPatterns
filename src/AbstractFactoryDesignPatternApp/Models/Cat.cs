using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp.Models
{
    public class Cat : Animal
    {
        public string Speak()
        {
            return "Meow";
        }
    }
}
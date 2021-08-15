using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp.Models
{
    public class Dog : Animal
    {
        public string Speak()
        {
            return "Haw";
        }
    }
}
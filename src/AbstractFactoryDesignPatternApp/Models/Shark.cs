using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp.Models
{
    public class Shark : Animal
    {
        public string Speak()
        {
            return "Cannot speak";
        }
    }
}
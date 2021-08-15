using AbstractFactoryDesignPatternApp.Interfaces;

namespace AbstractFactoryDesignPatternApp.Models
{
    public class Lion : Animal
    {
        public string Speak()
        {
            return "Roar";
        }
    }
}
using FactoryDesignPatternApp.Interfaces;
using FactoryDesignPatternApp.Models;

namespace FactoryDesignPatternApp.Factories
{
    public class PlatinumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Platinum();
            return product;
        }
    }
}
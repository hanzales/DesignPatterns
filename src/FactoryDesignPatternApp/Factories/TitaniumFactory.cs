using FactoryDesignPatternApp.Interfaces;
using FactoryDesignPatternApp.Models;

namespace FactoryDesignPatternApp.Factories
{
    public class TitaniumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Titanium();
            return product;
        }
    }
}
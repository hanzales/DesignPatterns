using FactoryDesignPatternApp.Interfaces;
using FactoryDesignPatternApp.Models;

namespace FactoryDesignPatternApp.Factories
{
    public class PlatinumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Platinum();
            return product;
        }
    }
}
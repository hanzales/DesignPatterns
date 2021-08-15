using FactoryDesignPatternApp.Interfaces;
using FactoryDesignPatternApp.Models;

namespace FactoryDesignPatternApp.Factories
{
    public class MoneyBankFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new MoneyBack();
            return product;
        }
    }
}

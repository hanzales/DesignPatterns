using FactoryDesignPatternApp.Interfaces;
using FactoryDesignPatternApp.Models;

namespace FactoryDesignPatternApp.Factories
{
    public class MoneyBankFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new MoneyBack();
            return product;
        }
    }
}

using FactoryDesignPatternApp.Interfaces;

namespace FactoryDesignPatternApp.Factories
{
    public abstract class CreditCardFactory
    {
        protected abstract CreditCard MakeProduct();

        public CreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
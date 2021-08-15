using FactoryDesignPatternApp.Interfaces;

namespace FactoryDesignPatternApp.Models
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
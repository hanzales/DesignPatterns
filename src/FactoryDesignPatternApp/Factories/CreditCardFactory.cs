﻿using FactoryDesignPatternApp.Interfaces;

namespace FactoryDesignPatternApp.Factories
{
    public abstract class CreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();

        public ICreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
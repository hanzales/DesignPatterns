using FactoryDesignPatternApp.Interfaces;
using System;

namespace FactoryDesignPatternApp.Models
{
    public class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            return 3000;
        }
    }
}

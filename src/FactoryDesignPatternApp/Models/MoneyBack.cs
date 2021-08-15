using FactoryDesignPatternApp.Interfaces;

namespace FactoryDesignPatternApp.Models
{
    public class MoneyBack : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 750;
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 5000;
        }
    }
}
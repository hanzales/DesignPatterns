using FactoryDesignPatternApp.Interfaces;

namespace FactoryDesignPatternApp.Models
{
    public class Platinum : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 555;
        }

        public string GetCardType()
        {
            return "Platinum Plus";
        }

        public int GetCreditLimit()
        {
            return 1000;
        }
    }
}
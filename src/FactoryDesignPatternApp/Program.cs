using FactoryDesignPatternApp.Models;
using System;

namespace FactoryDesignPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var creditCard = new PlatinumFactory().CreateProduct();

            if (!(creditCard is null))
            {
                Console.WriteLine("Card Type: " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit: " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge: " + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid card type.");
            }

            Console.ReadLine();
        }
    }
}
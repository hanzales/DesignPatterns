using System;
using FluentInterfaceDesignPatternApp.Models;

namespace FluentInterfaceDesignPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeObj = new FluentEmployee();

            employeeObj.NameOfThEmployee("İlhan Emir")
                .Born("01.09.1994")
                .WorkingOn("IT")
                .StaysAt("Turkey-Bursa");

            Console.ReadLine();
        }
    }
}
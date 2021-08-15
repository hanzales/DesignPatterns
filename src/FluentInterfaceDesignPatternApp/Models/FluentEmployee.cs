using System;

namespace FluentInterfaceDesignPatternApp.Models
{
    public class FluentEmployee
    {
        private Employee employee = new Employee();

        public FluentEmployee NameOfThEmployee(string fullName)
        {
            employee.FullName = fullName;
            return this;
        }

        public FluentEmployee Born(string dateOfBirth)
        {
            employee.DateOfBirth = Convert.ToDateTime(dateOfBirth);
            return this;
        }

        public FluentEmployee WorkingOn(string department)
        {
            employee.Department = department;
            return this;
        }

        public FluentEmployee StaysAt(string adress)
        {
            employee.Adress = adress;
            return this;
        }
    }
}
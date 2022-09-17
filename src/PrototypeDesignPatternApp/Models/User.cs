using System;

namespace PrototypeDesignPatternApp.Models
{
    public interface IUser : ICloneable
    {
        string Name { get; }
        int Age { get; }
        string Address { get; }
    }

    public class User : IUser
    {
        private string _name;
        private int _age;
        private string _address;

        public string Name => _name;
        public int Age => _age;
        public string Address => _address;

        public User(string name, string address)
        {
            _name = name;
            _address = address;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
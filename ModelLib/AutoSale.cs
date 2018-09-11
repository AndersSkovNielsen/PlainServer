using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    public class AutoSale
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private List<Car> _cars;

        public List<Car> Cars
        {
            get { return _cars; }
            set { _cars = value; }
        }

        public AutoSale()
        {

        }

        public AutoSale(string Name, string Address, List<Car> Cars)
        {
            _name = Name;
            _address = Address;
            _cars = Cars;
        }

        public override string ToString()
        {
            string aString = $"Name: {_name}, Address: {_address}\nList of Cars:\n";

            foreach (var car in _cars)
            {
                aString += car.ToString() + "\n";
            }

            return aString;
        }
    }
}

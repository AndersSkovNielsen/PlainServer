using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    public class Car
    {
        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        private string _regNr;

        public string RegNr
        {
            get { return _regNr; }
            set { _regNr = value; }
        }

        public Car()
        {
            
        }

        public Car(string model, string color, string regNr)
        {
            _model = model;
            _color = color;
            _regNr = regNr;
        }

        public override string ToString()
        {
            return $"Model: {_model}, Color: {_color}, RegNr: {_regNr}";
        }
    }
}

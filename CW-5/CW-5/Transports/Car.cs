using System;

namespace CW_5
{
    class Car:Transport
    {
        private string _brand;
        public string Brand
        {
            get
            {
                return _brand;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _brand = value;
                }
                else
                {
                    throw new FormatException();
                }
            }
        }
        public Car(Chassis chassis,Engine engine,Transmission transmission, string brand):base(chassis,engine,transmission)
        {
            Brand = brand;
        }
        public override string ToString()
        {
            return "Car\nBrand: " + Brand +"\n"+ base.ToString();
        }
    }
}

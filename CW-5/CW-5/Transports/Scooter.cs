using System;

namespace CW_5
{
    class Scooter:Transport
    {
        private float _price;
        public float Price
        {
            get
            {
                return _price;
            }
            private set
            {
                if(value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new FormatException();
                }
            }
        }
        public Scooter(Chassis chassis, Engine engine, Transmission transmission,float price):base(chassis,engine,transmission)
        {
            Price = price;
        }
        public override string ToString()
        {
            return"Scooter\nPrice: " +Price.ToString() + "\n"+ base.ToString();
        }
    }
}

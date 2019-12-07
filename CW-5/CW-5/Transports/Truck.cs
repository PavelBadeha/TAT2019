using System;

namespace CW_5
{
    class Truck:Transport
    {
        private float _mileage;
        public float Mileage
        {
            get
            {
                return _mileage;
            }
            private set
            {
                if(value >= 0)
                {
                    _mileage = value;
                }
                else
                {
                    throw new FormatException();
                }
            }
        }
        public Truck(Chassis chassis,Engine engine,Transmission transmission,float mileage):base(chassis,engine,transmission)
        {
            Mileage = mileage;
        }
        public override string ToString()
        {
            return "Truck\nMileage: " + Mileage.ToString() + "\n" + base.ToString();
        }
    }
}

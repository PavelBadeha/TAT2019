using System;

namespace CW_5
{
    class Transmission
    {
        private string _type;
        public string Type
        {
            get
            {
                return _type;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _type = value;
                }
                else
                {
                    throw new FormatException();
                }
            }
        }
        private int _gearAmount;
        public int GearAmount
        {
            get
            {
                return _gearAmount;
            }
            private set
            {
                if (value > 0)
                {
                    _gearAmount = value;
                }
                else
                {
                    throw new FormatException();
                }
            }
        }

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
        public Transmission (string type,int gearAmount,string brand)
        {
            Type = type;
            GearAmount = gearAmount;
            Brand = brand;
        }
        public override string ToString()
        {
            return "Transmission:\nType: " +
                    Type +
                    " ,Gear Amount: " +
                    GearAmount.ToString() +
                    " ,Brand :" +
                    Brand;
        }
    }
}

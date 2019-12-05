using System;

namespace CW_5
{
    class Engine
    {
        private float _power;
        public float Power
        {
            get
            {
                return _power;
            }
            private set
            {
                if (value>=0)
                {
                    _power = value;
                }
                else
                {
                    throw new FormatException();
                }
            }
        }
        private float _capacity;
        public float Capacity
        {
            get
            {
                return _capacity;
            }
            private set
            {
                if (value >= 0)
                {
                    _capacity = value;
                }
                else
                {
                    throw new FormatException();
                }
            }
        }

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

        private int _serialNumber;
        public int SerialNumber
        {
            get
            {
                return _serialNumber;
            }
            private set
            {
                if (value >= 0)
                {
                    _serialNumber = value;
                }
            }
        }
        public Engine(float power,float capacity,string type,int serialNumber)
        {
            Power = power;
            Capacity = capacity;
            Type = type;
            SerialNumber = serialNumber;
        }
        public override string ToString()
        {
            return "Engine:\nPower: " +
                    Power.ToString() +
                    " ,Capacity: " +
                    Capacity.ToString() +
                    " ,Type: " +
                    Type +
                    " ,Serial Number: " +
                    SerialNumber.ToString();
        }
    }
}

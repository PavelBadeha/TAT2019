using System;

namespace CW_5
{
    class Chassis
    {
        private int _wheelsAmount;
        public int WheelsAmount
        {
            get
            {
                return _wheelsAmount;
            }
            private set
            {
                if(value > 0 )
                {
                    _wheelsAmount = value;
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
                else
                {
                    throw new FormatException();
                }
            }
        }
        private float _maxLoad;
        public float MaxLoad
        {
            get
            {
                return _maxLoad;
            }
            private set
            {
                if (value >= 0)
                {
                    _maxLoad = value;
                }
                else
                {
                    throw new FormatException();
                }
            }
        }
        public Chassis(int wheelAmount,int serialNumber,float maxLoad)
        {
            WheelsAmount = wheelAmount;
            SerialNumber = serialNumber;
            MaxLoad = maxLoad;
        }
        public override string ToString()
        {
            return "Chassis:\nWheels Amount: " +
                    WheelsAmount.ToString() +
                    " ,Serial Number: " +
                    SerialNumber.ToString() +
                    " ,Max Load: " + MaxLoad.ToString();
        }
    }
}

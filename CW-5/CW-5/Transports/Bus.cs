using System;

namespace CW_5
{
    class Bus:Transport
    {
        private int _slotsAmount;
        public int SlotsAmount
        {
            get
            {
                return _slotsAmount;
            }
            private set
            {
                if(value > 0)
                {
                    _slotsAmount = value;
                }
                else
                {
                    throw new FormatException();
                }
            }
        }
        public Bus(Chassis chassis,Engine engine,Transmission transmission,int slotsAmount):base(chassis,engine,transmission)
        {
            SlotsAmount = slotsAmount;
        }
        public override string ToString()
        {
            return "Bus:\nSlots amount:" + SlotsAmount.ToString() + "\n" + base.ToString();
        }
    }
}

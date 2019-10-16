using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class Garage
    {
        public int QuantityOfSlots { get; }

        public Garage() { }

        public Garage(int quantityOfSlots)
        {
            QuantityOfSlots = quantityOfSlots;
        }
        public override string ToString()
        {
            return "Quantity Of Slots:"+QuantityOfSlots;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class Garage
    {
        public int QuantitySlots { get; }

        public Garage() { }

        public Garage(int quantitySlots)
        {
            QuantitySlots = quantitySlots;
        }
    }
}

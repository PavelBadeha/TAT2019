using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class Garage
    {
        public  int DepartmentId { get; }
        public int QuantityOfSlots { get; }

        public Garage() { }

        public Garage(int quantityOfSlots)
        {
            QuantityOfSlots = quantityOfSlots;
        }

        public Garage(int quantityOfSlots, int departmentId)
        {
            QuantityOfSlots = quantityOfSlots;
            DepartmentId = departmentId;
        }
        public override string ToString()
        {
            return "Quantity Of Slots:"+QuantityOfSlots;
        }
    }
}

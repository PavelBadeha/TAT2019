using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class DBOGarage
    {
        public int QuantityOfSlots { get; }
        public int ParkingId { get; }
        public DBOGarage(int freeSlots,int parkingId)
        {
            QuantityOfSlots = freeSlots;
            ParkingId = parkingId;
        }
    }
}

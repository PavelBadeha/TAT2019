using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class DBOCar
    {
        public string Brand { get; }
        public int Number { get; }
        public int ParkingId { get; }
        public DBOCar(int number,string brand,int parkingId)
        {
            Brand = brand;
            Number = number;
            ParkingId = parkingId;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class DBOParking
    {
        public string Name { get; }
        public int ParkingId { get; }
        public int UniversityId { get; }
        public DBOParking(string name, int parkingId, int universityId)
        {
            Name = name;
            ParkingId = parkingId;
            UniversityId = universityId;
        }
    }
}

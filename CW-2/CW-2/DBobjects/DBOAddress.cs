using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class DBOAddress
    {
        public string City { get; }
        public string Street { get; }
        public string HouseNumber { get; }
        public int HouseId { get; }
        public DBOAddress(string[] address,int houseId)
        {
            City = address[0];
            Street = address[1];
            HouseNumber = address[2];
            HouseId = houseId;
        }
    }
}

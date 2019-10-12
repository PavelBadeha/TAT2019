using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class DBOHead
    {
        public string Name { get; }
        public int Age { get; }
        public int CarNumber { get; }
        public int InstituteId { get; }
        public DBOHead(string name, int age, int carNumber, int instituteId)
        {
            Name = name;
            Age = age;
            CarNumber = carNumber;
            InstituteId = instituteId;
        }
    }
}

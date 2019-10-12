using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class DBOAccountant
    {
        public string Name { get; }
        public int Age { get; }
        public int HoursPerWeek { get; }
        public int ManagementId { get; }
        public DBOAccountant(string name, int age, int hoursPerWeek, int managementId)
        {
            Name = name;
            Age = age;
            HoursPerWeek = hoursPerWeek;
            ManagementId = managementId;
        }

    }
}

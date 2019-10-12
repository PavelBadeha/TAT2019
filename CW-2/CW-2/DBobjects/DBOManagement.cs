using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class DBOManagement
    {
        public string Name { get; }
        public int ManagementId { get; }
        public int UniversityId { get; }
        public DBOManagement(string name, int managementId, int universityId)
        {
            Name = name;
            ManagementId = managementId;
            UniversityId = universityId;
        }
    }
}

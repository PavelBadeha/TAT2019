using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class DBOInstitute
    {
        public string Name { get; }
        public int InstituteId { get; }
        public int UniversityId { get; }
        public DBOInstitute(string name, int instituteId, int universityId)
        {
            Name = name;
            InstituteId = instituteId;
            UniversityId = universityId;
        }
    }
}

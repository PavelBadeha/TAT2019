using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class DBOUniversity
    {
        public string Name { get; }
        public int UniversityId { get; }
        public DBOUniversity(string name, int universityId)
        {
            Name = name;
            UniversityId = universityId;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class DBOFaculty
    {
        public string Name { get; }
        public int FacultyId { get; }
        public int UniversityId { get; }
        public DBOFaculty(string name, int facultyId,int universityId)
        {
            Name = name;
            FacultyId = facultyId;
            UniversityId = universityId;
        }
    }
}

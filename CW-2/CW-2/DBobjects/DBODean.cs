using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class DBODean
    {
        public string Name { get; }
        public int Age { get; }
        public int Office { get; }
        public int FacultyId { get; }
        public DBODean(string name, int age, int office, int facultyId)
        {
            Name = name;
            Age = age;
            Office = office;
            FacultyId = facultyId;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class DBOStudent
    {
        public string Name { get; }
        public int Age { get; }
        public int[] Marks { get; } = new int[5];
        public int FacultyId { get; }
        public DBOStudent(string name,int age,int[]marks,int facultyId)
        {
            Name = name;
            Age = age;
            marks.CopyTo(Marks, 0);
            FacultyId = facultyId;
        }
    }
}

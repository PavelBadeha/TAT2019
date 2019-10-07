using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class UniversityCreator
    {
        private University university;
        public University GetUniversity(IDBProvider provider)
        {
            university = new University();
            university.AddDepartments(provider.GetDepartments());
            university.AddParkings(provider.GetParkings());
            return university;
        }
    }
}

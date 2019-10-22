using System;
using System.Collections.Generic;
using System.Linq;

namespace CW_2
{
    class UniversityCreator
    {
        private IDBProvider provider;
        public List<University> Universities { get; private set; } = new List<University>();
        public UniversityCreator(IDBProvider provider)
        {
            this.provider = provider;
        }

        public void CreateUniversities()
        {
            Universities = provider.GetUniversities();
        }
        public List<Student> GetStudents(string Name)
        {
            return provider.GetStudentsByFacultyName(Name);
        }
    }
}

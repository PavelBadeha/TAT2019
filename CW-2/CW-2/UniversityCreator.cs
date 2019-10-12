using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class UniversityCreator
    {
        private List<University> universities=new List<University>();
        private IDBProvider provider;

        public UniversityCreator(IDBProvider provider)
        {
            this.provider = provider;
        }

        public void CreateUniversities()
        {
            University university;
            foreach (var dbo in provider.GetDBOUniversities())
            {
                university = new University(dbo.Name);
                university.AddDepartments(provider.GetDepartmentsById(dbo.UniversityId));
                university.AddParkings(provider.GetParkingsById(dbo.UniversityId));
                universities.Add(university);
            }
        }
        public List<University> GetUniversities()
        {
            return universities;
        }
    }
}

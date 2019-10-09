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

        private void Initialization()
        {
            foreach (var university in provider.GetUniversities())
            {
                university.AddDepartments(provider.GetDepartments().FindAll(x=>x.UniversityId==university.UniversityId));
                university.AddParkings(provider.GetParkings().FindAll(x=>x.UniversityId==university.UniversityId));

                universities.Add(university);
            }
        }
        public UniversityCreator(IDBProvider provider)
        {
            this.provider = provider;
            Initialization();
        }
        
        public University GetUniversityById(int UniversityId)
        {
            return universities.Find(x => x.UniversityId == UniversityId);
        }

        public List<University> GetUniversities()
        {
            return universities;
        }
    }
}

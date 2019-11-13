using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace CW_2
{
    /// <summary>
    /// Class of json provider
    /// </summary>
    class JsonProvider:IDBProvider
    {
        /// <summary>
        /// File's derictory to write in
        /// </summary>
        private static string fileName = @"A:\repos\CW-2\CW-2\JsonFiles\Univer.json";

        /// <summary>
        /// List of univesrities
        /// </summary>
        private List<University> universities = new List<University>(); 
        
        /// <summary>
        /// Setting for serializer to serialize/deserialize inheraited classes correctly
        /// </summary>
        private JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

        /// <summary>
        /// Method that initialize universtites by reading json file
        /// </summary>
        public void Initialize()
        {
            universities = JsonConvert.DeserializeObject<List<University>>(File.ReadAllText(fileName), settings);
        }

        #region Methods of interface IDBProvider
        public List<University> GetUniversities()
        {
            return universities;
        }
        public Dean GetDeanByFacultyName(string facultyName)
        {
            Department faculty = universities.SelectMany(university => university.Departments)
                                 .Where(dep => dep.Name == facultyName).Select(x => x).Single();
            return (faculty as Faculty).Dean;
        }
        public Head GetHeadByDepartmentName(string departmentName)
        {
            Department department = universities.Select(university => university.Departments)
                               .Select(departments => departments.Find(dep => dep.Name == departmentName))
                               .Single();
            if (department is Parking)
            {
                return (department as Parking).Head;
            }
            if (department is Institute)
            {
                return (department as Institute).Head;
            }
            else
            {
                return (department as Management).Head;
            }
        }
        public Address GetAddressByDepartmentName(string departmentName)
        {
            Department department = universities.Select(university => university.Departments)
                               .Select(departments => departments.Find(dep => dep.Name == departmentName))
                               .Single();
            return department.Address;
        }
        public List<Student> GetStudentsByFacultyName(string departmentName)
        {
            return universities.SelectMany(university => university.Departments)
                             .Where(department => department.Name == departmentName)
                             .SelectMany(department => department.MemberList).Select(x=>(Student)x).ToList();
        }
        public List<Employee> GetEmployeesByInstituteName(string departmentName)
        {
            return universities.SelectMany(university => university.Departments)
                             .Where(department => department.Name == departmentName)
                             .SelectMany(department => department.MemberList).Select(x=>(Employee)x).ToList();
        }
        public List<Accountant> GetAccountantsByManagementName(string departmentName)
        {
            return universities.SelectMany(university => university.Departments)
                              .Where(department => department.Name == departmentName)
                              .SelectMany(department => department.MemberList).Select(x => (Accountant)x).ToList();
        }
        public List<Car> GetCarsByParkingName(string departmentName)
        {
            return universities.SelectMany(university => university.Departments)
                                .Where(department => department.Name == departmentName)
                                .Select(department => (Parking)department).SelectMany(x=>x.Cars).Select(x=>x).ToList();
        }
        public List<Garage> GetGaragesByParkingName(string departmentName)
        {
            return universities.SelectMany(university => university.Departments)
                                .Where(department => department.Name == departmentName)
                                .Select(department => (Parking)department).SelectMany(x => x.Garages).Select(x=>x).ToList();
        }
        public List<Department> GetDepartmentsByUniversityName(string universityName)
        {
            return universities.Where(university => university.Name.Equals(universityName))
                               .SelectMany(university => university.Departments).ToList();
        }
        public List<Parking> GetParkingsByUniversityName(string universityName)
        {
            return universities.Where(university => university.Name.Equals(universityName))
                               .SelectMany(university => university.Parkings).ToList();
        }
        #endregion

        #region Add to Json
        /// <summary>
        /// Method that can add university to json file
        /// </summary>
        /// <param name="university"></param>
        public void AddUniversity(University university)
        {
            universities.Add(university);
            File.WriteAllText(fileName, JsonConvert.SerializeObject(universities,settings));
        }

        /// <summary>
        /// Method that can add list of universities to json file
        /// </summary>
        /// <param name="universities"></param>
        public void AddUniversities(List<University> universities)
        {
            this.universities = universities;
            File.WriteAllText(fileName, JsonConvert.SerializeObject(universities, settings));
        }
        #endregion
    }
}

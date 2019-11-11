using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace CW_2
{
    class JsonProvider:IDBProvider
    {
        private static string fileName = @"A:\repos\CW-2\CW-2\JsonFiles\Univer.json";
        private List<University> universities = new List<University>();        
        private JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

        public void Initialize()
        {
            universities = JsonConvert.DeserializeObject<List<University>>(File.ReadAllText(fileName), settings);
        }
        
        public List<University> GetUniversities()
        {
            return universities;
        }

        #region Retunr list by name
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
        public void AddUniversity(University university)
        {
            universities.Add(university);
            File.WriteAllText(fileName, JsonConvert.SerializeObject(universities,settings));
        }
        public void AddUniversities(List<University> universities)
        {
            this.universities = universities;
            File.WriteAllText(fileName, JsonConvert.SerializeObject(universities, settings));
        }
        #endregion
    }
}

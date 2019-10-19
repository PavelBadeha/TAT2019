using System;
using System.Collections.Generic;
using System.Linq;

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
                university.AddDepartments(GetDepartmentsById(dbo.UniversityId));
                university.AddParkings(GetParkingsById(dbo.UniversityId));
                universities.Add(university);
            }
        }
        public List<University> GetUniversities()
        {
            return universities;
        }

        #region Search by Id
        public Address GetAddressById(int id)
        {
            return provider.GetDBOAddresses().Where(x=>x.HouseId==id).Select(x => new Address(x.City, x.Street, x.HouseNumber)).Single();
        }
        public Head GetHeadById(int id)
        {
            return provider.GetDBOHeads().Where(x =>x.InstituteId==id).Select(x => new Head(x.Name,x.Age,x.CarNumber)).Single();
        }
        public Dean GetDeanById(int id)
        {
            return provider.GetDBODeans().Where(x=>x.FacultyId==id).Select(x => new Dean(x.Name, x.Age, x.Office)).Single();
        }
        public List<Student> GetStudentsById(int id)
        {
            return provider.GetDBOStudents().Where(x => x.FacultyId == id)
                                            .Select(x=> new Student(x.Name, x.Age, x.Marks))
                                            .ToList();           
        }
        public List<Employee> GetEmployeesById(int id)
        {
            return provider.GetDBOEmployees().Where(x => x.InstituteId == id)
                                             .Select(x => new Employee(x.Name, x.Age, x.Salary))
                                             .ToList();
        }
        public List<Accountant> GetAccountantsById(int id)
        {
            return provider.GetDBOAccountants().Where(x => x.ManagementId == id)
                                             .Select(x => new Accountant(x.Name, x.Age, x.HoursPerWeek))
                                             .ToList();
        }
        public List<Car> GetCarsById(int id)
        {
            return provider.GetDBOCars().Where(x => x.ParkingId == id)
                                                .Select(x => new Car(x.Number,x.Brand))
                                                .ToList();
        }
        public List<Garage> GetGaragesById(int id)
        {
            return provider.GetDBOGarages().Where(x=>x.ParkingId==id).Select(x => new Garage(x.QuantityOfSlots)).ToList();
        }
        public List<Institute> GetInstiutesyById(int id)
        {
            return provider.GetDBOInstitutes().Where(x=>x.UniversityId==id)
                           .Select(x => new Institute(x.Name, GetAddressById(x.InstituteId)
                           , GetHeadById(x.InstituteId)
                           , GetEmployeesById(x.InstituteId)))
                           .ToList();
        }
        public List<Faculty> GetFacultiesById(int id)
        {
            return provider.GetDBOFaculties().Where(x=>x.UniversityId==id)
                           .Select(x => new Faculty(x.Name, GetAddressById(x.FacultyId)
                           , GetDeanById(x.FacultyId)
                           , GetStudentsById(x.FacultyId)))
                           .ToList();
        }
        public List<Management> GetManagementsById(int id)
        {
            return provider.GetDBOManagements().Where(x=>x.UniversityId==id)
                           .Select(x => new Management(x.Name, GetAddressById(x.ManagementId)
                           , GetHeadById(x.ManagementId)
                           , GetAccountantsById(x.ManagementId)))
                           .ToList();
        }
        public List<Department> GetDepartmentsById(int id)
        {
            List<Department> temp = new List<Department>();
            temp.AddRange(GetFacultiesById(id));
            temp.AddRange(GetInstiutesyById(id));
            temp.AddRange(GetManagementsById(id));
            return temp;
        }
        public List<Parking> GetParkingsById(int id)
        {
            return provider.GetDBOParkings().Where(x=>x.UniversityId==id)
                                            .Select(x => new Parking(x.Name, GetHeadById(x.ParkingId), GetGaragesById(x.ParkingId)
                                            , GetCarsById(x.ParkingId), GetAddressById(x.ParkingId)))
                                            .ToList();
        }
        #endregion

        #region Return all list
        public List<Address> GetAddresses()
        {
            return provider.GetDBOAddresses().Select(x => new Address(x.City, x.Street, x.HouseNumber)).ToList();
        }
        public List<Dean> GetDeans()
        {
            return provider.GetDBODeans().Select(x => new Dean(x.Name, x.Age, x.Office)).ToList();
        }
        public List<Head> GetHeads()
        {
            return provider.GetDBOHeads().Select(x => new Head(x.Name, x.Age,x.CarNumber)).ToList();
        }
        public List<Parking> GetParkings()
        {
            return provider.GetDBOParkings().Select(x => new Parking(x.Name,GetHeadById(x.ParkingId),GetGaragesById(x.ParkingId)
                                            ,GetCarsById(x.ParkingId),GetAddressById(x.ParkingId)))
                                            .ToList();
        }
        public List<Student> GetStudents()
        {
            return provider.GetDBOStudents().Select(x => new Student(x.Name,x.Age,x.Marks)).ToList();
        }
        public List<Employee> GetEmployees()
        {
            return provider.GetDBOEmployees().Select(x => new Employee(x.Name,x.Age,x.Salary)).ToList();
        }
        public List<Accountant> GetAccountants()
        {
            return provider.GetDBOAccountants().Select(x => new Accountant(x.Name, x.Age, x.HoursPerWeek)).ToList();
        }
        public List<Car> GetCars()
        {
            return provider.GetDBOCars().Select(x => new Car(x.Number,x.Brand)).ToList();
        }
        public List<Garage> GetGarages()
        {
            return provider.GetDBOGarages().Select(x => new Garage(x.QuantityOfSlots)).ToList();
        }
        public List<Faculty> GetFaculties()
        {
            return provider.GetDBOFaculties()
                           .Select(x => new Faculty(x.Name,GetAddressById(x.FacultyId)
                           ,GetDeanById(x.FacultyId)
                           ,GetStudentsById(x.FacultyId)))
                           .ToList();     
        }
        public List<Institute> GetInstiutes()
        {
            return provider.GetDBOInstitutes()
                          .Select(x => new Institute(x.Name, GetAddressById(x.InstituteId)
                          , GetHeadById(x.InstituteId)
                          , GetEmployeesById(x.InstituteId)))
                          .ToList();
        }
        public List<Management> GetManagements()
        {
            return provider.GetDBOManagements()
                          .Select(x => new Management(x.Name, GetAddressById(x.ManagementId)
                          , GetHeadById(x.ManagementId)
                          , GetAccountantsById(x.ManagementId)))
                          .ToList();
        }
        #endregion
    
    }
}

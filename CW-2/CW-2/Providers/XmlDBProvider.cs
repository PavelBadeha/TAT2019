using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace CW_2
{
    class XmlDBProvider:IDBProvider
    {
        private  const string FileName = "XmlFiles/University.xml";

        private List<DBOUniversity> dBOUniversities = new List<DBOUniversity>();
        private List<Department> departments =  new List<Department>();
        private List<DBOParking> dBOParkings = new List<DBOParking>();
        private List<DBODean> dBODeans = new List<DBODean>();
        private List<DBOHead> dBOHeads = new List<DBOHead>();
        private List<DBOStudent> dBOStudents = new List<DBOStudent>();
        private List<DBOEmployee> dBOEmployees = new List<DBOEmployee>();
        private List<DBOAccountant> dBOAccountants = new List<DBOAccountant>();
        private List<DBOCar> dBOCars = new List<DBOCar>();
        private List<DBOGarage> dBOGarages = new List<DBOGarage>();
        private List<DBOAddress> dBOAddresses = new List<DBOAddress>();
        private List<DBOFaculty> dBOFaculties = new List<DBOFaculty>();
        private List<DBOInstitute> dBOInstitutes = new List<DBOInstitute>();
        private List<DBOManagement> dBOManagements = new List<DBOManagement>();
        public void Initialization()
        {
            XmlReader reader = XmlReader.Create(FileName);
            while(reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "Dean":
                            dBODeans.Add(new DBODean(reader["Name"],
                                Int32.Parse(reader["Age"]),
                                Int32.Parse(reader["Office"]),
                                Int32.Parse(reader["DepartmentId"])));
                            break;
                        case "Head":
                            dBOHeads.Add(new DBOHead(reader["Name"],
                                Int32.Parse(reader["Age"]),
                                Int32.Parse(reader["CarNumber"]),
                                Int32.Parse(reader["DepartmentId"])));
                            break;
                        case "Student":
                            dBOStudents.Add(new DBOStudent(reader["Name"],
                                Int32.Parse(reader["Age"]),
                                reader["Marks"].Split(',').Select(x => Int32.Parse(x)).ToArray(),
                                Int32.Parse(reader["DepartmentId"])));
                            break;
                        case "Employee":
                                dBOEmployees.Add(new DBOEmployee(reader["Name"],Int32.Parse(reader["Age"]),
                                Int32.Parse(reader["Salary"]),
                                Int32.Parse(reader["DepartmentId"])));
                            break;
                        case "Accountant":
                            dBOAccountants.Add(new DBOAccountant(reader["Name"], Int32.Parse(reader["Age"]),
                                Int32.Parse(reader["HoursPerWeek"]),
                                Int32.Parse(reader["DepartmentId"])));
                            break;
                        case "Address":
                            dBOAddresses.Add(new DBOAddress(reader["Address"].Split(','),
                                Int32.Parse(reader["DepartmentId"])));
                            break;
                        case "Car":
                            dBOCars.Add(new DBOCar(Int32.Parse(reader["Number"]),
                                reader["Brand"],Int32.Parse(reader["DepartmentId"])));
                            break;
                        case "Garage":
                            dBOGarages.Add(new DBOGarage(Int32.Parse(reader["QuantityOfSlots"]),
                                Int32.Parse(reader["DepartmentId"])));
                            break;
                        case "University":
                            dBOUniversities.Add(new DBOUniversity(reader["Name"], Int32.Parse(reader["UniversityId"])));
                            break;
                        case "Faculty":
                            dBOFaculties.Add(new DBOFaculty(reader["Name"], Int32.Parse(reader["DepartmentId"]), Int32.Parse(reader["UniversityId"])));
                            break;
                        case "Insitute":
                            dBOInstitutes.Add(new DBOInstitute(reader["Name"], Int32.Parse(reader["DepartmentId"]), Int32.Parse(reader["UniversityId"])));
                            break;
                        case "Management":
                            dBOManagements.Add(new DBOManagement(reader["Name"], Int32.Parse(reader["DepartmentId"]), Int32.Parse(reader["UniversityId"])));
                            break;
                        case "Parking":
                            dBOParkings.Add(new DBOParking(reader["Name"], Int32.Parse(reader["DepartmentId"]), Int32.Parse(reader["UniversityId"])));
                            break;
                    }
                }
            }
        }
        public List<Department> GetDepartments()
        {
            departments.AddRange(GetInstiutes());
            departments.AddRange(GetManagements());
            departments.AddRange(GetFaculties());
            return departments;
        }

        #region Search by Id
        public Address GetAddressById(int id)
        {
            DBOAddress temp = dBOAddresses.Find(x => x.HouseId == id);
            return new Address(temp.City, temp.Street, temp.HouseNumber);
        }
        public Head GetHeadById(int id)
        {          
            DBOHead temp = dBOHeads.Find(x => x.InstituteId == id);
            return new Head(temp.Name, temp.Age, temp.CarNumber);
        }
        public Dean GetDeanById(int id)
        {
            DBODean temp = dBODeans.Find(x => x.FacultyId == id);
            return new Dean(temp.Name, temp.Age, temp.Office);
        }
        public List<Student> GetStudentsById(int id)
        {
            List<Student> students = new List<Student>();
            foreach (var dbo in dBOStudents)
            {
                if (dbo.FacultyId == id)
                {
                    students.Add(new Student(dbo.Name, dbo.Age, dbo.Marks));
                }
            }
            return students;
        }
        public List<Employee> GetEmployeesById(int id)
        {
            List<Employee> employees = new List<Employee>();
            foreach (var dbo in dBOEmployees)
            {
                if (dbo.InstituteId == id)
                {
                    employees.Add(new Employee(dbo.Name, dbo.Age, dbo.Salary));
                }
            }
            return employees;
        }
        public List<Accountant> GetAccountantsById(int id)
        {
            List<Accountant> accountants = new List<Accountant>();
            foreach (var dbo in dBOAccountants)
            {
                if (dbo.ManagementId == id)
                {
                    accountants.Add(new Accountant(dbo.Name, dbo.Age, dbo.HoursPerWeek));
                }
            }
            return accountants;
        }
        public List<Car> GetCarsById(int id)
        {
            List<Car> cars = new List<Car>();
            foreach (var dbo in dBOCars)
            {
                if (dbo.ParkingId == id)
                {
                    cars.Add(new Car(dbo.Number, dbo.Brand));
                }
            }
            return cars;
        }
        public List<Garage> GetGaragesById(int id)
        {
            List<Garage> garages = new List<Garage>();
            foreach (var dbo in dBOGarages)
            {
                if (dbo.ParkingId == id)
                {
                    garages.Add(new Garage(dbo.QuantityOfSlots));
                }
            }
            return garages;
        }
        public List<Institute> GetInstiutesyById(int id)
        {
            List<Institute> institutes = new List<Institute>();
            Institute temp;
            foreach (var dbo in dBOInstitutes)
            {
                if(dbo.InstituteId==id)
                {
                    temp = new Institute(dbo.Name, GetAddressById(dbo.InstituteId), GetHeadById(dbo.InstituteId));
                    temp.AddMembers(GetEmployeesById(dbo.InstituteId));
                    institutes.Add(temp);
                }       
            }
            return institutes;
        }
        public List<Faculty> GetFacultiesById(int id)
        {
            List<Faculty> faculties = new List<Faculty>();
            Faculty temp;
            foreach (var dbo in dBOFaculties)
            {
                if(dbo.FacultyId==id)
                {
                    temp = new Faculty(dbo.Name, GetAddressById(dbo.FacultyId), GetDeanById(dbo.FacultyId));
                    temp.AddMembers(GetStudentsById(dbo.FacultyId));
                    faculties.Add(temp);
                }
             
            }
            return faculties;
        }
        public List<Management> GetManagementsById(int id)
        {
            List<Management> managements = new List<Management>();
            Management temp;
            foreach (var dbo in dBOManagements)
            {
                if(dbo.ManagementId==id)
                {
                    temp = new Management(dbo.Name, GetAddressById(dbo.ManagementId), GetHeadById(dbo.ManagementId));
                    temp.AddMembers(GetAccountantsById(dbo.ManagementId));
                    managements.Add(temp);
                }
            }
            return managements;
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
            List<Parking> parkings = new List<Parking>();
            foreach (var dbo in dBOParkings)
            {
                if(dbo.UniversityId==id)
                {
                    parkings.Add(new Parking(dbo.Name, GetHeadById(dbo.ParkingId), GetAddressById(dbo.ParkingId)));
                }         
            }
            return parkings;
        }
        #endregion

        #region Return all list
        public List<Parking> GetParkings()
        {
            List<Parking> parkings = new List<Parking>();
            foreach (var dbo in dBOParkings)
            {
                parkings.Add(new Parking(dbo.Name, GetHeadById(dbo.ParkingId), GetAddressById(dbo.ParkingId)));
            }
            return parkings;
        }
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            foreach(var dbo in dBOStudents)
            {
                students.Add(new Student(dbo.Name, dbo.Age, dbo.Marks));
            }
            return students;
        }
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            foreach (var dbo in dBOEmployees)
            {
                employees.Add(new Employee(dbo.Name, dbo.Age, dbo.Salary));
            }
            return employees;
        }
        public List<Accountant> GetAccountants()
        {
            List<Accountant> accountants = new List<Accountant>();
            foreach (var dbo in dBOAccountants)
            {
                accountants.Add(new Accountant(dbo.Name, dbo.Age, dbo.HoursPerWeek));
            }
            return accountants;
        }
        public List<Car> GetCars()
        {
            List<Car> cars = new List<Car>();
            foreach (var dbo in dBOCars)
            {
                cars.Add(new Car(dbo.Number,dbo.Brand));
            }
            return cars;
        }
        public List<Garage> GetGarages()
        {
            List<Garage> garages = new List<Garage>();
            foreach (var dbo in dBOGarages)
            {
                garages.Add(new Garage(dbo.QuantityOfSlots));
            }
            return garages;
        }
        public List<Faculty> GetFaculties()
        {
            List<Faculty> faculties = new List<Faculty>();
            Faculty temp;
            foreach (var dbo in dBOFaculties)
            {
                temp = new Faculty(dbo.Name,GetAddressById(dbo.FacultyId),GetDeanById(dbo.FacultyId));
                temp.AddMembers(GetStudentsById(dbo.FacultyId));
                faculties.Add(temp);
            }
            return faculties;
        }
        public List<Institute> GetInstiutes()
        {
            List<Institute> institutes = new List<Institute>();
            Institute temp;
            foreach (var dbo in dBOInstitutes)
            {
                temp = new Institute(dbo.Name, GetAddressById(dbo.InstituteId), GetHeadById(dbo.InstituteId));
                temp.AddMembers(GetEmployeesById(dbo.InstituteId));
                institutes.Add(temp);
            }
            return institutes;
        }
        public List<Management> GetManagements()
        {
            List<Management> managements = new List<Management>();
            Management temp;
            foreach (var dbo in dBOManagements)
            {
                temp = new Management(dbo.Name, GetAddressById(dbo.ManagementId), GetHeadById(dbo.ManagementId));
                temp.AddMembers(GetAccountantsById(dbo.ManagementId));
                managements.Add(temp);
            }
            return managements;
        }
        #endregion

        public List<DBOUniversity> GetDBOUniversities()
        {
            return dBOUniversities;
        }
    }
}

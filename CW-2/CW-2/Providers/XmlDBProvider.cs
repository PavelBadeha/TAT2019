using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace CW_2
{
    class XmlDBProvider:IDBProvider
    {
        private  const string FileName = "XmlFiles/University.xml";

        private List<University> universities = new List<University>();
        private List<Department> departments =  new List<Department>();
        private List<Parking> parkings = new List<Parking>();
        private List<Dean> deans = new List<Dean>();
        private List<Head> heads= new List<Head>();
        private List<Student> students = new List<Student>();
        private List<Employee> employees = new List<Employee>();
        private List<Accountant> accountants = new List<Accountant>();
        private List<Car> cars = new List<Car>();
        private List<Garage> garages = new List<Garage>();
        private List<Address> addresses = new List<Address>();

        private void InitializationOfPersonsCarsAdddresses()
        {
            XmlReader reader = XmlReader.Create(FileName);
            while(reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "Dean":
                            deans.Add(new Dean(reader["Name"],
                                Int32.Parse(reader["Age"]),
                                Int32.Parse(reader["Office"]),
                                Int32.Parse(reader["DepartmentId"])));
                            break;
                        case "Head":
                            heads.Add(new Head(reader["Name"],
                                Int32.Parse(reader["Age"]),
                                Int32.Parse(reader["CarNumber"]),
                                Int32.Parse(reader["DepartmentId"])));
                            break;
                        case "Student":
                            students.Add(new Student(reader["Name"],
                                Int32.Parse(reader["Age"]),
                                reader["Marks"].Split(',').Select(x => Int32.Parse(x)).ToArray(),
                                Int32.Parse(reader["DepartmentId"])));
                            break;
                        case "Employee":
                            employees.Add(new Employee(reader["Name"],Int32.Parse(reader["Age"]),
                                Int32.Parse(reader["Salary"]),
                                Int32.Parse(reader["DepartmentId"])));
                            break;
                        case "Accountant":
                            accountants.Add(new Accountant(reader["Name"], Int32.Parse(reader["Age"]),
                                Int32.Parse(reader["HoursPerWeek"]),
                                Int32.Parse(reader["DepartmentId"])));
                            break;
                        case "Address":
                            addresses.Add(new Address(reader["Address"].Split(','),
                                Int32.Parse(reader["DepartmentId"])));
                            break;
                        case "Car":
                            cars.Add(new Car(Int32.Parse(reader["Number"]),
                                reader["Brand"],Int32.Parse(reader["DepartmentId"])));
                            break;
                        case "Garage":
                            garages.Add(new Garage(Int32.Parse(reader["QuantityOfSlots"]),
                                Int32.Parse(reader["DepartmentId"])));
                            break;

                    }
                }
            }
        }

        private void InitializationOfDepartments()
        {
            XmlReader reader = XmlReader.Create(FileName);
            Dean dean;
            Address address;
            Head head;
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "University":
                            universities.Add(new University(reader["Name"],Int32.Parse(reader["UniversityId"])));
                            break;
                        case "Faculty":
                            dean = deans.Find(x => x.DepartmentId == Int32.Parse(reader["DepartmentId"]));
                            address = addresses.Find(x => x.DepartmentId == Int32.Parse(reader["DepartmentId"]));
                            if (dean != null && address!=null)
                            {
                                 Faculty faculty = new Faculty(reader["Name"], dean, address,
                                Int32.Parse(reader["DepartmentId"]),
                                Int32.Parse(reader["UniversityId"]));

                            faculty.AddMembers(students.Where(x => x.DepartmentId == faculty.DepartmentId).ToList());
                            departments.Add(faculty);
                            }
                            break;
                        case "Institute":
                            head = heads.Find(x => x.DepartmentId == Int32.Parse(reader["DepartmentId"]));
                            address = addresses.Find(x => x.DepartmentId == Int32.Parse(reader["DepartmentId"]));
                            if (head != null && address != null)
                            {
                                Institute institute = new Institute(reader["Name"], head, address,
                                    Int32.Parse(reader["DepartmentId"]),
                                    Int32.Parse(reader["UniversityId"]));

                                institute.AddMembers(employees.Where(x => x.DepartmentId == institute.DepartmentId).ToList());
                                departments.Add(institute);
                            }

                            break;
                        case "Management":
                            head = heads.Find(x => x.DepartmentId == Int32.Parse(reader["DepartmentId"]));
                            address = addresses.Find(x => x.DepartmentId == Int32.Parse(reader["DepartmentId"]));
                            if (head != null && address != null)
                            {
                                Management management = new Management(reader["Name"], head, address,
                                    Int32.Parse(reader["DepartmentId"]),
                                    Int32.Parse(reader["UniversityId"]));

                                management.AddMembers(accountants.Where(x => x.DepartmentId == management.DepartmentId).ToList());
                                departments.Add(management);
                            }

                            break;
                        case "Parking":
                            head = heads.Find(x => x.DepartmentId == Int32.Parse(reader["DepartmentId"]));
                            address = addresses.Find(x => x.DepartmentId == Int32.Parse(reader["DepartmentId"]));
                            if (head != null && address != null)
                            {
                                Parking parking = new Parking(reader["Name"], head, address,
                                    Int32.Parse(reader["DepartmentId"]),
                                    Int32.Parse(reader["UniversityId"]));

                                parking.AddCars(cars.Where(x => x.DepartmentId == parking.DepartmentId).ToList());
                                parking.AddGarages(garages.Where(x => x.DepartmentId == parking.DepartmentId).ToList());

                                parkings.Add(parking);
                            }

                            break;
                    }
                }
            }

        }

        public XmlDBProvider()
        {
            InitializationOfPersonsCarsAdddresses();
            InitializationOfDepartments();
            //InitializationOfUniversities();
        }

        public List<Department> GetDepartments()
        {
            return departments;
        }

        public List<Parking> GetParkings()
        {
            return parkings;
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public List<Accountant> GetAccountants()
        {
            return accountants;
        }

        public List<Car> GetCars()
        {
            return cars;
        }

        public List<Garage> GetGarages()
        {
            return garages;
        }

        public List<University> GetUniversities()
        {
            return universities;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace CW_2
{
    class XmlProvider:IDBProvider
    {

        private XmlDocument xDocument = new XmlDocument();
        public XmlElement xRoot;

        private XmlNode departmentsXmlNode;

        //studentsXmlNode,
        //employeesXmlNode,
        //accountantsXmlNode,
        //deanXmlNode,
        //headXmlNode,
        //adddressXmlNode,
        //facultyXmlNode,
        //insituteXmlNode,
        //managementXmlNode;
        public XmlProvider(string nameOfXmlFile)
        {
            xDocument.Load(nameOfXmlFile);
            xRoot = xDocument.DocumentElement;
            departmentsXmlNode = xRoot["Departments"] != null ? xRoot["Departments"] : xRoot;
        }

        #region Methods
        public List<Student> GetStudents(string facultyName)
        {
            List<Student> students = new List<Student>();
            XmlNode facultyNode = xRoot["Departments"].SelectSingleNode($"Faculty[@Name='{facultyName}']");
            foreach (XmlNode studentNode in facultyNode["Students"])
            {
                students.Add(new Student(studentNode.Attributes["Name"].Value
                    , Int32.Parse(studentNode.Attributes["Age"].Value)
                    , studentNode.Attributes["Marks"].Value.Split(',')
                        .Select(element => Int32.Parse(element))
                        .ToArray()));
            }

            return students;
        }
        public List<Employee> GetEmployees(string instituteName)
        {
            List<Employee> employees = new List<Employee>();
            XmlNode instituteNode = xRoot["Departments"].SelectSingleNode($"Institute[@Name='{instituteName}']");
            foreach (XmlNode employeeNode in instituteNode["Employees"])
            {
                employees.Add(new Employee(employeeNode.Attributes["Name"].Value
                    , Int32.Parse(employeeNode.Attributes["Age"].Value)
                    , float.Parse(employeeNode.Attributes["Salary"].Value)));
            }

            return employees;
        }
        public List<Accountant> GetAccountants(string managementName)
        {
            List<Accountant> accountants = new List<Accountant>();
            XmlNode managemenetNode = xRoot["Departments"].SelectSingleNode($"Management[@Name='{managementName}']");
            foreach (XmlNode accountantNode in managemenetNode["Accountants"])
            {
                accountants.Add(new Accountant(accountantNode.Attributes["Name"].Value
                    , Int32.Parse(accountantNode.Attributes["Age"].Value)
                    , Int32.Parse(accountantNode.Attributes["HoursPerWeek"].Value)));
            }

            return accountants;
        }

        public Dean GetDean(string facultyName)
        {
            XmlNode facultyNode = xRoot["Departments"].SelectSingleNode($"Faculty[@Name='{facultyName}']");
            return new Dean(facultyNode["Dean"].Attributes["Name"].Value
                , Int32.Parse(facultyNode["Dean"].Attributes["Age"].Value)
                , Int32.Parse(facultyNode["Dean"].Attributes["Office"].Value));
        }

        public Head GetHead(string departmentName)
        {
            XmlNode departmentNode;
            foreach (XmlNode xmlNode in xRoot)
            {
                foreach (XmlNode childNode in xmlNode)
                {
                    if (xmlNode.SelectSingleNode($"{childNode.Name}[@Name='{departmentName}']") != null)
                    {
                        departmentNode = xmlNode.SelectSingleNode($"{childNode.Name}[@Name='{departmentName}']");
                        return new Head(departmentNode["Head"].Attributes["Name"].Value
                            , Int32.Parse(departmentNode["Head"].Attributes["Age"].Value)
                            , Int32.Parse(departmentNode["Head"].Attributes["CarNumber"].Value));
                    }
                }
            }
            return null;

        }

        public Address GetAddress(string departmentName)
        {
            XmlNode departmentNode;
            foreach (XmlNode xmlNode in xRoot)
            {
                foreach (XmlNode childNode in xmlNode)
                {
                    if (xmlNode.SelectSingleNode($"{childNode.Name}[@Name='{departmentName}']") != null)
                    {
                        departmentNode = xmlNode.SelectSingleNode($"{childNode.Name}[@Name='{departmentName}']");
                        return new Address(departmentNode["Address"].Attributes["Address"].Value.Split(','));
                    }
                }
            }
            return null;
        }

        public List<Faculty> GetFaculties()
        {
            List<Faculty> faculties = new List<Faculty>();
            Faculty faculty ;
            foreach (XmlNode facultyNode in xRoot["Departments"])
            {
                if (facultyNode.Name.Equals("Faculty"))
                {
                    faculty = new Faculty(facultyNode.Attributes["Name"].Value
                        , GetAddress(facultyNode.Attributes["Name"].Value)
                        , GetDean(facultyNode.Attributes["Name"].Value));
                    if (facultyNode["Students"] != null)
                    {
                        faculty.AddMembers(GetStudents(facultyNode.Attributes["Name"].Value));
                    }

                    faculties.Add(faculty);
                }
                
            }

            return faculties;
        }

        public List<Institute> GetInstitutes()
        {
            List<Institute> institutes = new List<Institute>();
            Institute institute;
            foreach (XmlNode instituteNode in xRoot["Departments"])
            {
                if (instituteNode.Name.Equals("Institute"))
                {
                    institute = new Institute(instituteNode.Attributes["Name"].Value
                        , GetAddress(instituteNode.Attributes["Name"].Value)
                        , GetHead(instituteNode.Attributes["Name"].Value));

                    if (instituteNode["Employees"] != null)
                    {
                        institute.AddMembers(GetEmployees(instituteNode.Attributes["Name"].Value));
                    }
                    institutes.Add(institute);
                }
            }
            return institutes; 
        }
        public List<Management> GetManagements()
        {
            List<Management> managements = new List<Management>();
            Management management;
            foreach (XmlNode managementNode in xRoot["Departments"])
            {
                if (managementNode.Name.Equals("Management"))
                {
                    management = new Management(managementNode.Attributes["Name"].Value
                        , GetAddress(managementNode.Attributes["Name"].Value)
                        , GetHead(managementNode.Attributes["Name"].Value));
                    if (managementNode["Accountants"] != null)
                    {
                        management.AddMembers(GetAccountants(managementNode.Attributes["Name"].Value));
                    }
                    managements.Add(management);
                }
            }
            return managements;
        }

        public List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();
            foreach (XmlNode departmentsNode in departmentsXmlNode)
            {
                if (departmentsNode.Name.Equals("Faculty"))
                {
                    departments.AddRange(GetFaculties());
                }

                if (departmentsNode.Name.Equals("Institute"))
                {
                    departments.AddRange(GetInstitutes());
                }

                if (departmentsNode.Name.Equals("Management"))
                {
                    departments.AddRange(GetManagements());
                }
            }

            return departments;
        }

        public List<Car> GetCars(string parkingName)
        {
            List<Car> cars = new List<Car>();
            XmlNode parkingNode = xRoot["Parkings"].SelectSingleNode($"Parking[@Name='{parkingName}']");
            foreach (XmlNode carNode in parkingNode["Cars"])
            {
                cars.Add(new Car(Int32.Parse(carNode.Attributes["Number"].Value), carNode.Attributes["Brand"].Value));
            }
            return cars;
        }

        public List<Garage> GetGarages(string parkingName)
        {
            List<Garage> garages = new List<Garage>();
            XmlNode parkingNode = xRoot["Parkings"].SelectSingleNode($"Parking[@Name='{parkingName}']");
            foreach (XmlNode garageNode in parkingNode["Garages"])
            {
                garages.Add(new Garage(Int32.Parse(garageNode.Attributes["QuantityOfSlots"].Value)));
            }
            return garages;
        }

        public List<Parking> GetParkings()
        {
            List<Parking> parkings = new List<Parking>();
            Parking parking;
            foreach (XmlNode parkingXmlNode in xRoot["Parkings"])
            {
                parking = new Parking(parkingXmlNode.Attributes["Name"].Value, GetHead(parkingXmlNode.Attributes["Name"].Value)
                    , GetAddress(parkingXmlNode.Attributes["Name"].Value));
                if (parkingXmlNode["Garages"] != null)
                {
                    foreach (var garage in GetGarages(parkingXmlNode.Attributes["Name"].Value))
                    {
                        parking.AddGarage(garage);
                    }
                }

                if (parkingXmlNode["Cars"] != null)
                {
                    foreach (var car in GetCars(parkingXmlNode.Attributes["Name"].Value))
                    {
                        parking.AddCar(car);
                    }

                }
                parkings.Add(parking);
            }

            return parkings;
        }
        #endregion
    }
}

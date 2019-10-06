using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CW_2
{
    class XmlParser
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
        public XmlParser(string nameOfXmlFile)
        {
            xDocument.Load(nameOfXmlFile);
            xRoot = xDocument.DocumentElement;
            departmentsXmlNode = xRoot["Departments"] != null ? xRoot["Departments"] : xRoot;
        }

        public List<Student> GetListOfStudentsFromXml(XmlNode studentsXmlNode)
        {
            List<Student> students = new List<Student>();
            foreach (XmlNode studentNode in studentsXmlNode)
            {
                students.Add(new Student(studentNode.Attributes["Name"].Value
                    , Int32.Parse(studentNode.Attributes["Age"].Value)
                    , studentNode.Attributes["Marks"].Value.Split(',')
                        .Select(element => Int32.Parse(element))
                        .ToArray()));
            }

            return students;
        }

        public List<Employee> GetListOfEmployeesFromXml(XmlNode employeesXmlNodeNode)
        {
            List<Employee> employees = new List<Employee>();
            foreach (XmlNode employeeNode in employeesXmlNodeNode)
            {
                employees.Add(new Employee(employeeNode.Attributes["Name"].Value
                    , Int32.Parse(employeeNode.Attributes["Age"].Value)
                    , float.Parse(employeeNode.Attributes["Salary"].Value)));
            }

            return employees;
        }

        public List<Accountant> GetListOfAccountantsFromXml(XmlNode accountantsXmlNode)
        {
            List<Accountant> accountants = new List<Accountant>();
            foreach (XmlNode accountantNode in accountantsXmlNode)
            {
                accountants.Add(new Accountant(accountantNode.Attributes["Name"].Value
                    , Int32.Parse(accountantNode.Attributes["Age"].Value)
                    , Int32.Parse(accountantNode.Attributes["HoursPerWeek"].Value)));
            }

            return accountants;
        }

        public Dean GetDeanFromXml(XmlNode deanXmlNode)
        {
            return new Dean(deanXmlNode.Attributes["Name"].Value
                , Int32.Parse(deanXmlNode.Attributes["Age"].Value)
                , Int32.Parse(deanXmlNode.Attributes["Office"].Value));
        }

        public Head GetHeadFromXml(XmlNode headXmlNode)
        {
            return new Head(headXmlNode.Attributes["Name"].Value
                , Int32.Parse(headXmlNode.Attributes["Age"].Value)
                , Int32.Parse(headXmlNode.Attributes["CarNumber"].Value));
        }

        public Address GeAddressFromXml(XmlNode addressXmlNode)
        {
            return new Address(addressXmlNode.Attributes["Address"].Value.Split(','));
        }

        public Faculty GetFacultyFromXml(XmlNode facultyXmlNode)
        {
            Faculty faculty = new Faculty(facultyXmlNode.Attributes["Name"].Value
                , GeAddressFromXml(addressXmlNode: facultyXmlNode["Address"])
                , GetDeanFromXml(deanXmlNode: facultyXmlNode["Dean"]));
            if (facultyXmlNode["Students"] != null)
            {
                faculty.AddMembers(GetListOfStudentsFromXml(facultyXmlNode["Students"]));
            }

            return faculty;
        }

        public Institute GetInstituteFromXml(XmlNode instituteXmlNode)
        {
            Institute institute = new Institute(instituteXmlNode.Attributes["Name"].Value
                , GeAddressFromXml(addressXmlNode: instituteXmlNode["Address"])
                , GetHeadFromXml(headXmlNode: instituteXmlNode["Head"]));
          
            if (instituteXmlNode["Employees"] != null)
            {
                institute.AddMembers(GetListOfEmployeesFromXml(instituteXmlNode["Employees"]));
            }

            return institute;
        }

        public Management GetManagementFromXml(XmlNode managementXmlNode)
        {
            Management management = new Management(managementXmlNode.Attributes["Name"].Value
                , GeAddressFromXml(addressXmlNode: managementXmlNode["Address"])
                , GetHeadFromXml(headXmlNode: managementXmlNode["Head"]));
            if (managementXmlNode["Accountants"] != null)
            {
                management.AddMembers(GetListOfAccountantsFromXml(managementXmlNode["Accountants"]));
            }

            return management;
        }

        public List<Department> GetDepartmentsFromXml()
        {
            List<Department> departments = new List<Department>();
            foreach (XmlNode departmentsNode in departmentsXmlNode)
            {
                if (departmentsNode.Name.Equals("Faculty"))
                {
                    departments.Add(GetFacultyFromXml(departmentsNode));
                }

                if (departmentsNode.Name.Equals("Institute"))
                {
                    departments.Add(GetInstituteFromXml(departmentsNode));
                }

                if (departmentsNode.Name.Equals("Management"))
                {
                    departments.Add(GetManagementFromXml(departmentsNode));
                }
            }

            return departments;
        }

        public List<Car> GetCarsFromXml(XmlNode carsXmlNode)
        {
            List<Car> cars = new List<Car>();
            foreach (XmlNode carNode in carsXmlNode)
            {
                cars.Add(new Car(Int32.Parse(carNode.Attributes["Number"].Value), carNode.Attributes["Brand"].Value));
            }

            return cars;
        }

        public List<Garage> GetGaragesFromXml(XmlNode garagesXmlNode)
        {
            List<Garage> garages = new List<Garage>();
            foreach (XmlNode garageNode in garagesXmlNode)
            {
                garages.Add(new Garage(Int32.Parse(garageNode.Attributes["QuantityOfSlots"].Value)));
            }

            return garages;
        }

        public Parking GetParkingFromXml(XmlNode parkingXmlNode)
        {
            Parking parking = new Parking(parkingXmlNode.Attributes["Name"].Value, GetHeadFromXml(parkingXmlNode["Head"])
                , GeAddressFromXml(addressXmlNode: parkingXmlNode["Address"]));
            if (parkingXmlNode["Garages"] != null)
            {
                foreach (var garage in GetGaragesFromXml(parkingXmlNode["Garages"]))
                {
                    parking.AddGarage(garage);
                }
            }

            if (parkingXmlNode["Cars"] != null)
            {
                foreach (var car in GetCarsFromXml(parkingXmlNode["Cars"]))
                {
                    parking.AddCar(car);
                }

            }

            return parking;
        }

        public List<Parking> GetParkingsFromXml()
        {
            List<Parking> parkings = new List<Parking>();
            foreach (XmlNode parkingXmlNode in xRoot?["Parkings"])
            {
                parkings.Add(GetParkingFromXml(parkingXmlNode));
            }

            return parkings;
        }

        public University GetUniversityFromXml()
        {
            University university = new University();
            university.AddDepartments(GetDepartmentsFromXml());
            university.AddParkings(GetParkingsFromXml());
            return university;
        }
    }
}

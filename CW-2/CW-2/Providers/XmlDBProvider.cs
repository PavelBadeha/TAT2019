using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace CW_2
{
    class XmlDBProvider:IDBProvider
    {
        private static string fileName = "XmlFiles/University.xml";

        private List<DBOUniversity> dBOUniversities = new List<DBOUniversity>();
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

        private XDocument document;
        public XmlDBProvider()
        {
            document = XDocument.Load(fileName);
        }
        public XmlDBProvider(string fileName)
        {
            XmlDBProvider.fileName = fileName;
            document = XDocument.Load(fileName);
        }
      

        #region Methods of Inititialization
        private void InitializeDBODeans()
        {
            dBODeans = document.Descendants("Dean").Select(x => new DBODean(x.Attribute("Name").Value
                                                                         , int.Parse(x.Attribute("Age").Value)
                                                                         , int.Parse(x.Attribute("Office").Value)
                                                                         , int.Parse(x.Attribute("DepartmentId").Value))).ToList();
        }
        private void InitializeDBOHeads()
        {
            dBOHeads = document.Descendants("Head").Select(x => new DBOHead(x.Attribute("Name").Value
                                                                         , int.Parse(x.Attribute("Age").Value)
                                                                         , int.Parse(x.Attribute("CarNumber").Value)
                                                                         , int.Parse(x.Attribute("DepartmentId").Value))).ToList();
        }
        private void InitializeDBOStudents()
        {
            dBOStudents = document.Descendants("Student").Select(x => new DBOStudent(x.Attribute("Name").Value
                                                                         , int.Parse(x.Attribute("Age").Value)
                                                                         , x.Attribute("Marks").Value.Split(',').Select(n=>int.Parse(n)).ToArray()
                                                                         , int.Parse(x.Attribute("DepartmentId").Value))).ToList();
        }
        private void InitializeDBOEmployees()
        {
            dBOEmployees = document.Descendants("Employee").Select(x => new DBOEmployee(x.Attribute("Name").Value
                                                                         , int.Parse(x.Attribute("Age").Value)
                                                                         , int.Parse(x.Attribute("Salary").Value)
                                                                         , int.Parse(x.Attribute("DepartmentId").Value))).ToList();
        }
        private void InitializeDBOAccountants()
        {
            dBOAccountants = document.Descendants("Accountant").Select(x => new DBOAccountant(x.Attribute("Name").Value
                                                                         , int.Parse(x.Attribute("Age").Value)
                                                                         , int.Parse(x.Attribute("HoursPerWeek").Value)
                                                                         , int.Parse(x.Attribute("DepartmentId").Value))).ToList();
        }
        private void InitializeDBOCars()
        {
            dBOCars = document.Descendants("Car").Select(x => new DBOCar( int.Parse(x.Attribute("Number").Value)
                                                                          ,x.Attribute("Brand").Value
                                                                         , int.Parse(x.Attribute("DepartmentId").Value))).ToList();
        }
        private void InitializeDBOGarages()
        {
            dBOGarages = document.Descendants("Garage").Select(x => new DBOGarage(int.Parse(x.Attribute("QuantityOfSlots").Value)
                                                                                 ,int.Parse(x.Attribute("DepartmentId").Value))).ToList();
        }
        private void InitializeDBOParkings()
        {
            dBOParkings = document.Descendants("Parking").Select(x => new DBOParking(x.Attribute("Name").Value
                                                                         , int.Parse(x.Attribute("DepartmentId").Value)
                                                                         , int.Parse(x.Attribute("UniversityId").Value))).ToList();
        }
        private void InitializeDBOFaculties()
        {
            dBOFaculties = document.Descendants("Faculty").Select(x => new DBOFaculty(x.Attribute("Name").Value
                                                                         , int.Parse(x.Attribute("DepartmentId").Value)
                                                                         , int.Parse(x.Attribute("UniversityId").Value))).ToList();
        }
        private void InitializeDBOInsitutes()
        {
            dBOInstitutes = document.Descendants("Institute").Select(x => new DBOInstitute(x.Attribute("Name").Value
                                                                         , int.Parse(x.Attribute("DepartmentId").Value)
                                                                         , int.Parse(x.Attribute("UniversityId").Value))).ToList();
        }
        private void InitializeDBOManagements()
        {
            dBOManagements = document.Descendants("Management").Select(x => new DBOManagement(x.Attribute("Name").Value
                                                                         , int.Parse(x.Attribute("DepartmentId").Value)
                                                                         , int.Parse(x.Attribute("UniversityId").Value))).ToList();
        }
        private void InitializeDBOAddress()
        {
            dBOAddresses = document.Descendants("Address").Select(x => new DBOAddress(x.Attribute("Address").Value.Split(',')
                                                                         , int.Parse(x.Attribute("DepartmentId").Value))).ToList();
        }
        private void InitializeDBOUniversities()
        {
            dBOUniversities = document.Descendants("University").Select(x => new DBOUniversity(x.Attribute("Name").Value
                                                                         , int.Parse(x.Attribute("UniversityId").Value))).ToList();
        }
        public void Initialization()    
        {
            InitializeDBOAccountants();
            InitializeDBOAddress();
            InitializeDBOCars();
            InitializeDBODeans();
            InitializeDBOEmployees();
            InitializeDBOFaculties();
            InitializeDBOGarages();
            InitializeDBOHeads();
            InitializeDBOInsitutes();
            InitializeDBOManagements();
            InitializeDBOParkings();
            InitializeDBOStudents();
            InitializeDBOUniversities();
        }
        #endregion

        #region Return DBO
        public List<DBOParking> GetDBOParkings()
        {
            return dBOParkings;
        }
        public List<DBODean> GetDBODeans()
        {
            return dBODeans;
        }
        public List<DBOHead> GetDBOHeads()
        {
            return dBOHeads;
        }
        public List<DBOStudent> GetDBOStudents()
        {
            return dBOStudents;
        }
        public List<DBOEmployee> GetDBOEmployees()
        {
            return dBOEmployees;
        }
        public List<DBOAccountant> GetDBOAccountants()
        {
            return dBOAccountants;
        }
        public List<DBOAddress> GetDBOAddresses()
        {
            return dBOAddresses;
        }
        public List<DBOCar> GetDBOCars()
        {
            return dBOCars;
        }
        public List<DBOGarage> GetDBOGarages()
        {
            return dBOGarages;
        }
        public List<DBOFaculty> GetDBOFaculties()
        {
            return dBOFaculties;
        }
        public List<DBOInstitute> GetDBOInstitutes()
        {
            return dBOInstitutes;
        }
        public List<DBOManagement> GetDBOManagements()
        {
            return dBOManagements;
        }
        public List<DBOUniversity> GetDBOUniversities()
        {
            return dBOUniversities;
        }
        #endregion

        #region Add to Xml
        public void AddStudent(Student student,int departmentId)
        {
            StringBuilder marks = new StringBuilder();
            for (int i = 0; i < student.Marks.Length; i++)
            {
                marks.Append(student.Marks[i]);
                if (marks.Length < student.Marks.Length * 2 - 1)
                {
                    marks.Append(",");
                }
            }
            document.Root.Element("Students").Add(new XElement("Student",
                   new XAttribute("Name", student.Name)
                 , new XAttribute("Age", student.Age)
                 , new XAttribute("Marks", marks.ToString())
                , new XAttribute("DepartmentId", departmentId)));


            document.Save(fileName);
        }
        public void AddEmployee(Employee employee,int departmentId)
        {
            document.Root.Element("Employees").Add(new XElement("Employee",
                         new XAttribute("Name", employee.Name)
                       , new XAttribute("Age", employee.Age)
                       , new XAttribute("Salary", employee.Salary)
                      , new XAttribute("DepartmentId", departmentId)));

            document.Save(fileName);
        }
        public void AddAccountant(Accountant accountant,int departmentId)
        {
            document.Root.Element("Accountants").Add(new XElement("Accountant",
                   new XAttribute("Name",accountant.Name)
                 , new XAttribute("Age", accountant.Age)
                 , new XAttribute("HoursPerWeek",accountant.HoursPerWeek)
                , new XAttribute("DepartmentId", departmentId)));

            document.Save(fileName);
        }
        public void AddCar(Car car,int departmentId)
        {
            document.Root.Element("Cars").Add(new XElement("Car",
                                                new XAttribute("Brand", car.Brand)
                                              , new XAttribute("Number",car.Number)
                                              , new XAttribute("DepartmentId", departmentId)));

            document.Save(fileName);
        }
        public void AddGarage(Garage garage, int departmentId)
        {
            document.Root.Element("Garages").Add(new XElement("Garage",
                                                new XAttribute("QuantityOfSlots", garage.QuantityOfSlots)
                                              , new XAttribute("DepartmentId", departmentId)));

            document.Save(fileName);
        }
        public void AddAddress(Address address,int departmentId)
        { 
            document.Root.Element("Addresses").Add(new XElement("Address",
                   new XAttribute("Address",address.City+","+address.Street+","+address.HouseNumber)
                , new XAttribute("DepartmentId", departmentId)));

            document.Save(fileName);
        }
        public void AddDean(Dean dean,int departmentId)
        {
            document.Root.Element("Deans").Add(new XElement("Dean",
                 new XAttribute("Name", dean.Name)
               , new XAttribute("Age", dean.Age)
               , new XAttribute("Office", dean.Office)
              , new XAttribute("DepartmentId", departmentId)));

            document.Save(fileName);
        }
        public void AddHead(Head head, int departmentId)
        {
            document.Root.Element("Heads").Add(new XElement("Head",
                 new XAttribute("Name", head.Name)
               , new XAttribute("Age", head.Age)
               , new XAttribute("CarNumber", head.CarNumber)
              , new XAttribute("DepartmentId", departmentId)));

            document.Save(fileName);
        }
        public void AddParking(Parking parking,int departmentId,int universityId)
        {
            document.Root.Element("Parkings").Add(new XElement("Parking",
                 new XAttribute("Name", parking.Name)
                 , new XAttribute("DepartmentId", departmentId)
                 , new XAttribute("UniversityId", universityId)));

            foreach (Car car in parking.Cars)
            {
                AddCar(car, departmentId);
            }
            foreach (Garage garage in parking.Garages)
            {
                AddGarage(garage, departmentId);
            }
            AddHead(parking.Head, departmentId);
            AddAddress(parking.Address, departmentId);

            document.Save(fileName);
        }
        public void AddFaculty(Faculty faculty,int departmentId,int universityId)
        {
            document.Root.Element("Departments").Add(new XElement("Faculty",
                 new XAttribute("Name", faculty.Name)
                 , new XAttribute("DepartmentId", departmentId)
                 , new XAttribute("UniversityId", universityId)));

            foreach(Student student in faculty.MemberList)
            {
                AddStudent(student, departmentId);
            }
            AddDean(faculty.Dean, departmentId);
            AddAddress(faculty.Address, departmentId);

            document.Save(fileName);
        }
        public void AddInstitute(Institute institute, int departmentId, int universityId)
        {
            document.Root.Element("Departments").Add(new XElement("Institute",
                 new XAttribute("Name", institute.Name)
                 , new XAttribute("DepartmentId", departmentId)
                 , new XAttribute("UniversityId", universityId)));

            foreach(Employee employee in institute.MemberList)
            {
                AddEmployee(employee, departmentId);
            }

            AddHead(institute.Head, departmentId);
            AddAddress(institute.Address, departmentId);

            document.Save(fileName);
        }
        public void AddManagement(Management management, int departmentId, int universityId)
        {
            document.Root.Element("Departments").Add(new XElement("Management",
                 new XAttribute("Name", management.Name)
                 , new XAttribute("DepartmentId", departmentId)
                 , new XAttribute("UniversityId", universityId)));

            foreach (Accountant accountant in management.MemberList)
            {
                AddAccountant(accountant, departmentId);
            }

            AddHead(management.Head, departmentId);
            AddAddress(management.Address, departmentId);

            document.Save(fileName);
        }
        public void AddUniversity(University university)
       {
            int universityId = 0;
            int departmentId = 0;
            if (document.Root.Element("Universities") != null)
            {
                universityId = int.Parse(document.Descendants("University").Last().Attribute("UniversityId").Value) + 1;
            }
            
            if(document.Descendants().Last().Attribute("DepartmentId") != null)
            {
                departmentId = int.Parse(document.Descendants().Last().Attribute("DepartmentId").Value) + 1;
            }
            

            document.Root.Element("Universities").Add(new XElement("University",
                new XAttribute("Name", university.Name)
                , new XAttribute("UniversityId", universityId)));
            
            foreach(var dep in university.Departments)
            {
                if(dep is Faculty)
                {
                    AddFaculty((Faculty)dep,departmentId,universityId);
                }

                if (dep is Management)
                {
                    AddManagement((Management)dep, departmentId, universityId);
                }

                if (dep is Institute)
                {
                    AddInstitute((Institute)dep, departmentId, universityId);
                }

                departmentId++;
            }
            foreach(var parking in university.Parkings)
            {
                AddParking(parking,departmentId,universityId);
                departmentId++;
            }

            document.Save(fileName);
        }
        #endregion
    }
}

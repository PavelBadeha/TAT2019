using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CW_2
{
    /// <summary>
    /// Class of xml provider
    /// </summary>
    class XmlDBProvider:IDBProvider
    {
        /// <summary>
        /// File's derictory
        /// </summary>
        private const string fileName = "XmlFiles/University.xml";

        /// <summary>
        /// Lists of all data base objects
        /// </summary>
        #region DBOLists
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
        #endregion

        /// <summary>
        ///List of universities 
        /// </summary>
        private List<University> universities = new List<University>();

        /// <summary>
        /// Xml document
        /// </summary>
        private XDocument document;

        /// <summary>
        /// Class constructors
        /// </summary>
        public XmlDBProvider()
        {
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
        private void InitializeUniversities()
        {
            universities = dBOUniversities.Select(university => new University(university.Name
                                                              , GetDepartmentsById(university.UniversityId)
                                                              , GetParkingsById(university.UniversityId))).ToList();
        }
        public void Initialize()
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
            InitializeUniversities();
        }
       
        #endregion

        /// <summary>
        /// Methods that returns lists of DBO
        /// </summary>
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

        /// <summary>
        /// Method that can search objects by id
        /// </summary>
        #region Search by Id
        public Address GetAddressById(int id)
        {
            return GetDBOAddresses().Where(x => x.HouseId == id).Select(x => new Address(x.City, x.Street, x.HouseNumber)).Single();
        }
        public Head GetHeadById(int id)
        {
            return GetDBOHeads().Where(x => x.InstituteId == id).Select(x => new Head(x.Name, x.Age, x.CarNumber)).Single();
        }
        public Dean GetDeanById(int id)
        {
            return GetDBODeans().Where(x => x.FacultyId == id).Select(x => new Dean(x.Name, x.Age, x.Office)).Single();
        }
        public List<Student> GetStudentsById(int id)
        {
            return GetDBOStudents().Where(x => x.FacultyId == id)
                                            .Select(x => new Student(x.Name, x.Age, x.Marks))
                                            .ToList();
        }
        public List<Employee> GetEmployeesById(int id)
        {
            return GetDBOEmployees().Where(x => x.InstituteId == id)
                                             .Select(x => new Employee(x.Name, x.Age, x.Salary))
                                             .ToList();
        }
        public List<Accountant> GetAccountantsById(int id)
        {
            return GetDBOAccountants().Where(x => x.ManagementId == id)
                                             .Select(x => new Accountant(x.Name, x.Age, x.HoursPerWeek))
                                             .ToList();
        }
        public List<Car> GetCarsById(int id)
        {
            return GetDBOCars().Where(x => x.ParkingId == id)
                                                .Select(x => new Car(x.Number, x.Brand))
                                                .ToList();
        }
        public List<Garage> GetGaragesById(int id)
        {
            return GetDBOGarages().Where(x => x.ParkingId == id).Select(x => new Garage(x.QuantityOfSlots)).ToList();
        }
        public List<Institute> GetInstiutesyById(int id)
        {
            return GetDBOInstitutes().Where(x => x.UniversityId == id)
                           .Select(x => new Institute(x.Name, GetAddressById(x.InstituteId)
                           , GetHeadById(x.InstituteId)
                           , GetEmployeesById(x.InstituteId)))
                           .ToList();
        }
        public List<Faculty> GetFacultiesById(int id)
        {
            return GetDBOFaculties().Where(x => x.UniversityId == id)
                           .Select(x => new Faculty(x.Name, GetAddressById(x.FacultyId)
                           , GetDeanById(x.FacultyId)
                           , GetStudentsById(x.FacultyId)))
                           .ToList();
        }
        public List<Management> GetManagementsById(int id)
        {
            return GetDBOManagements().Where(x => x.UniversityId == id)
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
            return GetDBOParkings().Where(x => x.UniversityId == id)
                                            .Select(x => new Parking(x.Name, GetHeadById(x.ParkingId), GetGaragesById(x.ParkingId)
                                            , GetCarsById(x.ParkingId), GetAddressById(x.ParkingId)))
                                            .ToList();
        }
        #endregion

        /// <summary>
        /// Method that returns all list of Departments/Faculties/Managements/Institute/Universtities/Persons/Parking e.t.c.
        /// </summary>
        #region Return all list
        public List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();
            departments.AddRange(GetFaculties());
            departments.AddRange(GetInstiutes());
            departments.AddRange(GetManagements());
            return departments;
        }
        public List<Address> GetAddresses()
        {
            return GetDBOAddresses().Select(x => new Address(x.City, x.Street, x.HouseNumber)).ToList();
        }
        public List<Dean> GetDeans()
        {
            return GetDBODeans().Select(x => new Dean(x.Name, x.Age, x.Office)).ToList();
        }
        public List<Head> GetHeads()
        {
            return GetDBOHeads().Select(x => new Head(x.Name, x.Age, x.CarNumber)).ToList();
        }
        public List<Parking> GetParkings()
        {
            return GetDBOParkings().Select(x => new Parking(x.Name, GetHeadById(x.ParkingId), GetGaragesById(x.ParkingId)
                                            , GetCarsById(x.ParkingId), GetAddressById(x.ParkingId)))
                                            .ToList();
        }
        public List<Student> GetStudents()
        {
            return GetDBOStudents().Select(x => new Student(x.Name, x.Age, x.Marks)).ToList();
        }
        public List<Employee> GetEmployees()
        {
            return GetDBOEmployees().Select(x => new Employee(x.Name, x.Age, x.Salary)).ToList();
        }
        public List<Accountant> GetAccountants()
        {
            return GetDBOAccountants().Select(x => new Accountant(x.Name, x.Age, x.HoursPerWeek)).ToList();
        }
        public List<Car> GetCars()
        {
            return GetDBOCars().Select(x => new Car(x.Number, x.Brand)).ToList();
        }
        public List<Garage> GetGarages()
        {
            return GetDBOGarages().Select(x => new Garage(x.QuantityOfSlots)).ToList();
        }
        public List<Faculty> GetFaculties()
        {
            return GetDBOFaculties()
                           .Select(x => new Faculty(x.Name, GetAddressById(x.FacultyId)
                           , GetDeanById(x.FacultyId)
                           , GetStudentsById(x.FacultyId)))
                           .ToList();
        }
        public List<Institute> GetInstiutes()
        {
            return GetDBOInstitutes()
                          .Select(x => new Institute(x.Name, GetAddressById(x.InstituteId)
                          , GetHeadById(x.InstituteId)
                          , GetEmployeesById(x.InstituteId)))
                          .ToList();
        }
        public List<Management> GetManagements()
        {
            return GetDBOManagements()
                          .Select(x => new Management(x.Name, GetAddressById(x.ManagementId)
                          , GetHeadById(x.ManagementId)
                          , GetAccountantsById(x.ManagementId)))
                          .ToList();
        }
        public List<University> GetUniversities()
        {
            return universities;
        }
        #endregion

        #region Methods of interface IDBProvider
        public Dean GetDeanByFacultyName(string facultyName)
        {
            Department faculty = universities.Select(university => university.Departments)
                               .Select(departments => departments.Find(department => department.Name == facultyName))
                               .Single();
            return (faculty as Faculty).Dean;
        }
        public Head GetHeadByDepartmentName(string departmentName)
        {
            Department department = universities.Select(university => university.Departments)
                               .Select(departments => departments.Find(dep => dep.Name == departmentName))
                               .Single();
            if(department is Parking)
            {
                return (department as Parking).Head;
            }
            if(department is Institute)
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
            int id = dBOFaculties.Find(x => x.Name == departmentName).FacultyId;
            return GetStudentsById(id);
        }
        public List<Employee> GetEmployeesByInstituteName(string departmentName)
        {
            int id = dBOInstitutes.Find(x => x.Name == departmentName).InstituteId;
            return GetEmployeesById(id);
        }
        public List<Accountant> GetAccountantsByManagementName(string departmentName)
        {
            int id = dBOManagements.Find(x => x.Name == departmentName).ManagementId;
            return GetAccountantsById(id);
        }
        public List<Car> GetCarsByParkingName(string departmentName)
        {
            int id = dBOParkings.Find(x => x.Name == departmentName).ParkingId;
            return GetCarsById(id);
        }
        public List<Garage> GetGaragesByParkingName(string departmentName)
        {
            int id = dBOParkings.Find(x => x.Name == departmentName).ParkingId;
            return GetGaragesById(id);
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

        /// <summary>
        /// Methods that can add object to xml file
        /// </summary>
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

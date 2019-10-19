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

        private XmlReader reader;
     
        public void Initialization()
        {
            reader = XmlReader.Create(FileName);
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

    }
}

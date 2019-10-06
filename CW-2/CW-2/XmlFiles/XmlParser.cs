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
        public XmlParser(string nameOfXmlFile)
        {
            xDocument.Load(nameOfXmlFile);
            xRoot = xDocument.DocumentElement;
            departmentsXmlNode = xRoot["Departments"] != null ? xRoot["Departments"] : xRoot;
        }

        public List<Student> GetListOfStudents(XmlNode studentsXmlNode)
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
        public List<Employee> GetListOfEmployees(XmlNode employeesXmlNodeNode)
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
        public List<Accountant> GetListOfAccountants(XmlNode accountantXmlNode)
        {
            List<Accountant> accountants = new List<Accountant>();
            foreach (XmlNode accountantNode in accountantXmlNode)
            {
                accountants.Add(new Accountant(accountantNode.Attributes["Name"].Value
                    , Int32.Parse(accountantNode.Attributes["Age"].Value)
                    , Int32.Parse(accountantNode.Attributes["Hours per week"].Value)));
            }
            return accountants;
        }
        public Dean GetDean(XmlNode deanXmlNode)
        {
            return  new Dean(deanXmlNode.Attributes["Name"].Value
                            ,Int32.Parse(deanXmlNode.Attributes["Age"].Value)
                            ,Int32.Parse(deanXmlNode.Attributes["Office"].Value));
        }
        public Head GetHead(XmlNode headXmlNode)
        {
            return new Head(headXmlNode.Attributes["Name"].Value
                , Int32.Parse(headXmlNode.Attributes["Age"].Value)
                , Int32.Parse(headXmlNode.Attributes["CarNumber"].Value));
        }
        public Address GeAddress(XmlNode addressXmlNode)
        {
            return new Address(addressXmlNode.Attributes["Address"].Value.Split(','));
        }
        public Faculty GeFaculty(XmlNode facultyXmlNode)
        {
            Faculty faculty = new Faculty(facultyXmlNode.Attributes["Name"].Value
                    ,GeAddress(addressXmlNode:facultyXmlNode["Address"])
                    ,GetDean(deanXmlNode:facultyXmlNode["Dean"]));
            if (facultyXmlNode["Students"] != null)
            {
                faculty.AddMembers(GetListOfStudents(facultyXmlNode["Students"]));
            }
            return faculty;
        }
        public Institute GetInstitute(XmlNode instituteXmlNode)
        {
            Institute institute = new Institute(instituteXmlNode.Attributes["Name"].Value
                , GeAddress(addressXmlNode: instituteXmlNode["Address"])
                , GetHead(headXmlNode: instituteXmlNode["Head"]));
            if (instituteXmlNode["Empployees"] != null)
            {
                institute.AddMembers(GetListOfEmployees(instituteXmlNode["Employees"]));
            }

            return institute;
        }
        public Management GetManagement(XmlNode managementXmlNode)
        {
            Management management = new Management(managementXmlNode.Attributes["Name"].Value
                , GeAddress(addressXmlNode: managementXmlNode["Address"])
                , GetHead(headXmlNode: managementXmlNode["Head"]));
            if (managementXmlNode["Head"] != null)
            {
                management.AddMembers(GetListOfAccountants(managementXmlNode["Head"]));
            }
            return management;
        }
        public List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();   
            foreach (XmlNode departmentsNode in departmentsXmlNode)
            {
                if (departmentsNode.Name.Equals("Faculty"))
                {
                    departments.Add(GeFaculty(departmentsNode));
                }

                if (departmentsNode.Name.Equals("Institute"))
                {
                    departments.Add(GetInstitute(departmentsNode));
                }

                if (departmentsNode.Name.Equals("Management"))
                {
                    departments.Add(GetManagement(departmentsNode));
                }
            }
            return departments;
        }
    }
}

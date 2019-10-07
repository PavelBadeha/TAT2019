using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    interface IDBProvider
    {
        List<Student> GetStudents(string facultyName);
        List<Employee> GetEmployees(string instituteName);
        List<Accountant> GetAccountants(string managementName);
        Dean GetDean(string facultyName);
        Head GetHead(string instituteName);
        Address GetAddress(string departmentName);
        List<Faculty> GetFaculties();
        List<Institute> GetInstitutes();
        List<Management> GetManagements();
        List<Department> GetDepartments();
        List<Car> GetCars(string parkingName);
        List<Garage> GetGarages(string parkingName);
        List<Parking> GetParkings();


    }
}

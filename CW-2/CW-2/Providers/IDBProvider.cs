using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    interface IDBProvider
    {
        List<Student> GetStudents();
        List<Employee> GetEmployees();
        List<Accountant> GetAccountants();
        List<Department> GetDepartments();
        List<Car> GetCars();
        List<Garage> GetGarages();
        List<Parking> GetParkings();
        List<University> GetUniversities();
    }
}

using System.Collections.Generic;

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
        List<DBOUniversity> GetDBOUniversities();
        List<Department> GetDepartmentsById(int id);
        List<Parking> GetParkingsById(int id);
    }
}

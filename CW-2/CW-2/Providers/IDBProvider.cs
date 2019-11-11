using System.Collections.Generic;

namespace CW_2
{
    interface IDBProvider
    {
        List<University> GetUniversities();
        Dean GetDeanByFacultyName(string facultyName);
        Head GetHeadByDepartmentName(string departmentName);
        Address GetAddressByDepartmentName(string departmentName);
        List<Student> GetStudentsByFacultyName(string departmentName);
        List<Employee> GetEmployeesByInstituteName(string departmentName);
        List<Accountant> GetAccountantsByManagementName(string departmentName);
        List<Car> GetCarsByParkingName(string departmentName);
        List<Garage> GetGaragesByParkingName(string departmentName);
        List<Department> GetDepartmentsByUniversityName(string universityName);
        List<Parking> GetParkingsByUniversityName(string universityName);
    }
}

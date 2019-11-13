using System.Collections.Generic;

namespace CW_2
{
    /// <summary>
    /// Interface of providers
    /// </summary>
    interface IDBProvider
    {
        /// <summary>
        /// Method that returns universities
        /// </summary>
        /// <returns></returns>
        List<University> GetUniversities();

        /// <summary>
        /// Method that return dean by faculty's name
        /// </summary>
        /// <param name="facultyName">Name of faculty</param>
        /// <returns>Dean</returns>
        Dean GetDeanByFacultyName(string facultyName);

        /// <summary>
        /// Method that return head by department's name
        /// </summary>
        /// <param name="departmentName">Name of deparment</param>
        /// <returns>Head</returns>
        Head GetHeadByDepartmentName(string departmentName);

        /// <summary>
        /// Method that returns address by department's name
        /// </summary>
        /// <param name="departmentName">Name of deparment</param>
        /// <returns>Address</returns>
        Address GetAddressByDepartmentName(string departmentName);

        /// <summary>
        /// Method that returns list of students by faculty's name
        /// </summary>
        /// <param name="departmentName">Name of faculty</param>
        /// <returns></returns>
        List<Student> GetStudentsByFacultyName(string departmentName);

        /// <summary>
        /// Method that returns list of employees by institute's name
        /// </summary>
        /// <param name="departmentName">Name of institute</param>
        /// <returns></returns>
        List<Employee> GetEmployeesByInstituteName(string departmentName);

        /// <summary>
        /// Method that returns list of accountant by management's name
        /// </summary>
        /// <param name="departmentName">Name of management</param>
        /// <returns></returns>
        List<Accountant> GetAccountantsByManagementName(string departmentName);

        /// <summary>
        /// Method that returns list of cars by parking's name
        /// </summary>
        /// <param name="departmentName">Name of parking</param>
        /// <returns></returns>
        List<Car> GetCarsByParkingName(string departmentName);

        /// <summary>
        /// Method that returns list of garages by parking's name
        /// </summary>
        /// <param name="departmentName">Name of parking</param>
        /// <returns></returns>
        List<Garage> GetGaragesByParkingName(string departmentName);

        /// <summary>
        /// Method that returns list of departments by university's name
        /// </summary>
        /// <param name="universityName">Name of university</param>
        /// <returns></returns>
        List<Department> GetDepartmentsByUniversityName(string universityName);

        /// <summary>
        /// Method that returns list of parkings by university's name
        /// </summary>
        /// <param name="universityName">Name of university</param>
        /// <returns></returns>
        List<Parking> GetParkingsByUniversityName(string universityName);
    }
}

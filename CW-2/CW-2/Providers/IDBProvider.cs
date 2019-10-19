using System.Collections.Generic;

namespace CW_2
{
    interface IDBProvider
    {
        
        List<DBOStudent> GetDBOStudents();
        List<DBOEmployee> GetDBOEmployees();
        List<DBOAccountant> GetDBOAccountants();
        List<DBOHead> GetDBOHeads();
        List<DBODean> GetDBODeans();
        List<DBOFaculty> GetDBOFaculties();
        List<DBOInstitute> GetDBOInstitutes();
        List<DBOManagement> GetDBOManagements();
        List<DBOCar> GetDBOCars();
        List<DBOAddress> GetDBOAddresses();
        List<DBOGarage> GetDBOGarages();
        List<DBOParking> GetDBOParkings();
        List<DBOUniversity> GetDBOUniversities();
    
    }
}

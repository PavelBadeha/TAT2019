
namespace CW_2
{
    /// <summary>
    /// Class of head data base object
    /// </summary>
    class DBOManagement
    {
        public string Name { get; }

        /// <summary>
        /// Own Id
        /// </summary>
        public int ManagementId { get; }

        /// <summary>
        /// Id of the univesrity that has this management
        /// </summary>
        public int UniversityId { get; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="managementId"></param>
        /// <param name="universityId"></param>
        public DBOManagement(string name, int managementId, int universityId)
        {
            Name = name;
            ManagementId = managementId;
            UniversityId = universityId;
        }
    }
}

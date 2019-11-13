using System.Collections.Generic;

namespace CW_2
{
    /// <summary>
    /// Class that creates univesities by using provider
    /// </summary>
    class UniversityCreator
    {
        /// <summary>
        /// Provider which implements interface IDBProvider
        /// </summary>
        private IDBProvider provider;

        /// <summary>
        ///List of universties 
        /// </summary>
        public List<University> Universities { get; private set; } = new List<University>();

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="provider">Provider</param>
        public UniversityCreator(IDBProvider provider)
        {
            this.provider = provider;
        }

        /// <summary>
        /// Method that create universtites
        /// </summary>
        public void CreateUniversities()
        {
            Universities = provider.GetUniversities();
        }
    }
}

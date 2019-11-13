using Newtonsoft.Json;

namespace CW_2
{
    /// <summary>
    /// Class of person
    /// </summary>
    class Person
    {
        #region Propierties
        /// <summary>
        /// Name of person
        /// </summary>
        [JsonProperty]
        public string Name { get; private set; } = string.Empty;

        /// <summary>
        /// Age of person
        /// </summary>
        [JsonProperty]
        public int Age { get; private set; }
        #endregion

        /// <summary>
        /// Class constructors without params
        /// </summary>
        public Person() { }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="name">Name of person</param>
        /// <param name="age">Age of person</param>
        public Person(string name, int age)
        {
            Name = name;

            if (0 < age && age < 150)
            {
                Age = age;
            }
        }

        /// <summary>
        /// Method that overrides method "Equals(object obj)".
        /// </summary>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Person person;

            if (obj is Person)
            {
                person = (Person) obj;
            }
            else
            {
                person =  new Person();
            }

            return Name.Equals(person.Name) && Age == person.Age;
        }

        /// <summary>
        /// Method that overrides method "ToString()".
        /// </summary>
        /// <returns>String representation of the person.</returns>
        public override string ToString()
        {
            return "Name:"+Name+" Age:"+Age;
        }
    }
}

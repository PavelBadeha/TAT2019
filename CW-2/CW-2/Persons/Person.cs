using Newtonsoft.Json;

namespace CW_2
{
    /// <summary>
    /// Class of person
    /// </summary>
    abstract class Person
    {
        [JsonProperty]
        public string Name { get; private set; } = string.Empty;

        [JsonProperty]
        public int Age { get; private set; }

        public Person() { }

        public Person(string name, int age)
        {
            Name = name;

            if (0 < age && age < 150)
            {
                Age = age;
            }
        }
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

        public override string ToString()
        {
            return "Name:"+Name+" Age:"+Age;
        }
    }
}

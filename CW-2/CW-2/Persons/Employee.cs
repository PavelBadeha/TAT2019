using Newtonsoft.Json;

namespace CW_2
{
    class Employee:Person
    {
        [JsonProperty]
        public float Salary { get;private set; } = 150;

        public Employee() { }
        public Employee(string name, int age, float salary) : base(name, age)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return "Employee\n" +base.ToString()+" Salary:"+Salary;
        }
    }
}

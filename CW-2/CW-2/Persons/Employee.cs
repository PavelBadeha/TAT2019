using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class Employee:Person
    {
        public float Salary { get; set; } = 150;

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

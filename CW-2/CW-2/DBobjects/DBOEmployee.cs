using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class DBOEmployee
    {
        public string Name { get; }
        public int Age { get; }
        public int Salary{ get; }
        public int InstituteId { get; }
        public DBOEmployee(string name, int age, int salary, int insituteId)
        {
            Name = name;
            Age = age;
            Salary = salary;
            InstituteId = insituteId;
        }
    }
}

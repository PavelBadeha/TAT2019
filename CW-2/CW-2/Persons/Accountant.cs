using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class Accountant:Person
    {
        public int HoursPerWeek { get; } = 40;

        public Accountant() { }

        public Accountant(string name, int age, int hoursPerWeek) : base(name, age)
        {
            HoursPerWeek = hoursPerWeek;
        }
    }
}

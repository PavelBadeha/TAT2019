using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace CW_2
{
    class Accountant:Person
    {
        [JsonProperty]
        public int HoursPerWeek { get; private set; } = 40;

        public Accountant() { }
        public Accountant(string name, int age, int hoursPerWeek) : base(name, age)
        {
            HoursPerWeek = hoursPerWeek;
        }

        public override string ToString()
        {
            return "Accountant\n" +base.ToString()+" Hours per week:"+ HoursPerWeek ;
        }
    }
}

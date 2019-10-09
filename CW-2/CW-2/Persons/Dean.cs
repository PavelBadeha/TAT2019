using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class Dean:Person
    {
        public int Office { get; set; }

        public Dean() { }

        public Dean(string name, int age, int office, int departmentId) : base(name, age, departmentId)
        {
            Office = office;
        }
        public Dean(string name, int age, int office) : base(name, age)
        {
            Office = office;
        }

        public override string ToString()
        {
            return "Dean\n"+base.ToString()+" Office:"+Office;
        }
    }
}

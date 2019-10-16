using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class Head:Person
    {
        public int CarNumber { get; set; }

        public Head() { }
        public Head(string name, int age,int carNumber) : base(name, age)
        {
            CarNumber = carNumber;
        }

        public override string ToString()
        {
            return "Head\n" + base.ToString()+" Car number:"+CarNumber;
        }
    }
}

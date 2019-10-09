using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class Car
    {
        public  int DepartmentId { get; }
        public int Number { get; }
        public string Brand { get; } = String.Empty;
        public Car() { }
        public Car(int number,string brand)
        {
            Number = number;
            Brand = brand;
        }

        public Car(int number, string brand, int departmentId)
        {
            Number = number;
            Brand = brand;
            DepartmentId = departmentId;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class Car
    {
        public int Number { get; }
        public string Brand { get; } = String.Empty;
        public Car() { }
        public Car(int number,string brand)
        {
            Number = number;
            Brand = brand;
        }
    }
}

using System;
using Newtonsoft.Json;

namespace CW_2
{
    class Car
    {
        [JsonProperty]
        public int Number { get; private set; }

        [JsonProperty]
        public string Brand { get; private set; } = String.Empty;
        public Car() { }
        public Car(int number,string brand)
        {
            Number = number;
            Brand = brand;
        }
    }
}

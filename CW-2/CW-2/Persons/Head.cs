using Newtonsoft.Json;

namespace CW_2
{
    class Head:Person
    {
        [JsonProperty]
        public int CarNumber { get; private set; }

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
